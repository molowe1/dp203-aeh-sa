using Azure.Messaging.EventHubs.Consumer;
using System.Text;


  string connection_string = "Endpoint=sb://dp2-3-eventhubdemo.servicebus.windows.net/;SharedAccessKeyName=EventSendPolicy;SharedAccessKey=Q/W6lkjlIzBDe6mLCaPC9OE2ijTI4PAkG+AEhDLyBho=;EntityPath=dp203-apphub;EntityPath=dp203-apphub";
  string consumer_group = "$Default";

EventHubConsumerClient _client = new EventHubConsumerClient(consumer_group, connection_string);

    await foreach (PartitionEvent _event in _client.ReadEventsAsync())
    {
        Console.WriteLine($"Partition ID {_event.Partition.PartitionId}");
        Console.WriteLine($"Data Offset {_event.Data.Offset}");
        Console.WriteLine($"Sequence Number {_event.Data.SequenceNumber}");
        Console.WriteLine($"Partition Key {_event.Data.PartitionKey}");
        Console.WriteLine(Encoding.UTF8.GetString(_event.Data.EventBody));
    }
    Console.ReadKey();

