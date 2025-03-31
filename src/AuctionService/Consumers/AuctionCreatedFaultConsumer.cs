using Contracts;
using MassTransit;

namespace AuctionService.Consumers;

public class AuctionCreatedFaultConsumer : IConsumer<Fault<AuctionCreated>>
{
    public async Task Consume(ConsumeContext<Fault<AuctionCreated>> context)
    {
        Console.WriteLine("---> Consuming fault for AuctionCreated event");

        var exception = context.Message.Exceptions.FirstOrDefault();

        if (exception == null)
        {
            Console.WriteLine("---> No exception details found in the fault.");
            return;
        }

        Console.WriteLine($"---> ExceptionType: {exception.ExceptionType}, Message: {exception.Message}");

        if (exception.ExceptionType == "System.ArgumentException")
        {
            Console.WriteLine("---> Republishing the original message due to ArgumentException");

            // Ensure the message exists
            if (context.Message.Message != null)
            {
                await context.Publish(context.Message.Message);
            }
            else
            {
                Console.WriteLine("---> Original message is null, cannot republish.");
            }
        }
        else
        {
            Console.WriteLine("---> Unhandled exception type, no action taken.");
        }
    }
}
