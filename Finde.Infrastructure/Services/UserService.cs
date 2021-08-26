using AutoMapper;
using Finde.Core.Domain;
using Finde.Core.Repositories;
using Finde.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEncrypter _encrypter;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IEncrypter encrypter, IMapper mapper)
        {
            _userRepository = userRepository;
            _encrypter = encrypter;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> BrowseAsync()
        {
            var drivers = await _userRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(drivers);
        }

        public Task<UserDTO> GetAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task RegisterAsync(Guid userId, string email, string username, string password)
        {
            var user = await _userRepository.GetAsync(email);

            if(user != null)
            {
                throw new Exception($"User with email: '{email}' already exists.");
            }

            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            user = new User(userId, email, password, salt, hash, username);
            await _userRepository.AddAsync(user);
        }

        public async Task ChangeUserPassword(Guid userId, string newPassword)
        {
            var user = await _userRepository.GetAsync(userId);

        }
    }
}
