
using TheOrchestrator.ClientSdk.DataAccess.Entities;

namespace TheOrchestrator.ClientSdk.DataAccess.Contracts;

public interface IMessageOutbox
{
    public MessageEnvelope GetMessageById(string messageId);

    public int GetMessageCount();

    public bool PrepareOutboxMessagesForTransaction();

    public bool CompleteOutboxMessagesInTransaction();

    public void RollbackTransaction();

    public void AddMessage(MessageOutboxEntity message);

    public void RemoveDuplicatePendingSubmission();

    public ReadyForSubmissionBatch GetNextMessagesReadyForSubmission(int batchSize);

    public void DeleteOldMessageHistory(object session);

}
