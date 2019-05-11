using System.Collections.Generic;
using CqrsExemplo.Domain;
using CqrsExemplo.Domain.Core;
using CqrsExemplo.Infra.Data;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CqrsExemplo.Infra.CrossCutting.IoC
{
    public static class RegisterDomainDependenciesExtensions
    {
        public static void RegisterDomainServices(this IServiceCollection services)
        {            
            //Repositories
            services.AddSingleton<IPessoaFakeData, PessoaFakeData>();
            services.AddTransient<IPessoaRepository, PessoaRepository>();
            services.AddTransient<IPessoaQueryRepository, PessoaQueryRepository>();

            // Commands
            services.AddScoped<IRequestHandler<AdicionarPessoaCommand, ICommandResult>, AdicionarPessoaCommandHandler>();

            //Events
            services.AddScoped<INotificationHandler<NovaPessoaAdicionadaEvent>, NovaPessoaAdicionadaEventHandler>();

            //Queries
            services.AddScoped<IRequestHandler<PessoaEmBrancoQuery, List<PessoaModel>>, PessoaQueryHandler>();
            services.AddScoped<IRequestHandler<PessoaIdQuery, PessoaModel>, PessoaQueryHandler>();
        }
    }
}