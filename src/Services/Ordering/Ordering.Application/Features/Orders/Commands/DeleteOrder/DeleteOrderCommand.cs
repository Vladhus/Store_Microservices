using MediatR;

namespace Ordering.Application.Features.Commands.Queries.DeleteOrder
{
    public class DeleteOrderCommand : IRequest
    {
        public int Id { get; set; }
    }
}
