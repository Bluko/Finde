using Autofac;
using Finde.Infrastructure.Mongo;
using Finde.Infrastructure.Repositories;
using MongoDB.Driver;
using System.Linq;
using System.Reflection;

namespace Finde.Infrastructure.IoC.Modules
{
    public class MongoModule : Autofac.Module
    {
		protected override void Load(ContainerBuilder builder)
		{
			builder.Register((c, p) =>
			{
				var settings = c.Resolve<MongoSettings>();

				return new MongoClient(settings.ConnectionString);
			}).SingleInstance();

			builder.Register((c, p) =>
			{
				var mongoClient = c.Resolve<MongoClient>();
				var settings = c.Resolve<MongoSettings>();
				var database = mongoClient.GetDatabase(settings.Database);

				return database;
			}).As<IMongoDatabase>();

			var assembly = typeof(MongoModule)
				.GetTypeInfo()
				.Assembly;

			builder.RegisterAssemblyTypes(assembly)
				   .Where(x => x.IsAssignableTo<IMongoRepository>())
				   .AsImplementedInterfaces()
				   .InstancePerLifetimeScope();
		}
	}
}
