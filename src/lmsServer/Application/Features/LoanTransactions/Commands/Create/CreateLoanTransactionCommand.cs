using Application.Features.LoanTransactions.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using NArchitecture.Core.Mailing;

namespace Application.Features.LoanTransactions.Commands.Create;

public class CreateLoanTransactionCommand : IRequest<CreatedLoanTransactionResponse>, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid MemberId { get; set; }
    public Guid BookId { get; set; }
    public ReturnStatus? ReturnStatus { get; set; }
    public DateTime ReturnTime { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetLoanTransactions"];

    public class CreateLoanTransactionCommandHandler : IRequestHandler<CreateLoanTransactionCommand, CreatedLoanTransactionResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILoanTransactionRepository _loanTransactionRepository;
        private readonly LoanTransactionBusinessRules _loanTransactionBusinessRules;
        private readonly IMailService _mailService;
        public CreateLoanTransactionCommandHandler(IMapper mapper, ILoanTransactionRepository loanTransactionRepository,
            LoanTransactionBusinessRules loanTransactionBusinessRules,IMailService mailService)
        {
            _mapper = mapper;
            _loanTransactionRepository = loanTransactionRepository;
            _loanTransactionBusinessRules = loanTransactionBusinessRules;
            _mailService = mailService;
        }

        public async Task<CreatedLoanTransactionResponse> Handle(CreateLoanTransactionCommand request, CancellationToken cancellationToken)
        {
            
            LoanTransaction loanTransaction = _mapper.Map<LoanTransaction>(request);

            await _loanTransactionRepository.AddAsync(loanTransaction);
            

            CreatedLoanTransactionResponse response = _mapper.Map<CreatedLoanTransactionResponse>(loanTransaction);
            return response;
        }
    }
}