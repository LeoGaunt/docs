---
title: "MSMQ Transport"
ms.date: "03/30/2017"
ms.assetid: 3f29a2fe-24df-4614-b64c-b0c084fb7003
---
# MSMQ Transport

This topic lists all exceptions generated by the MSMQ Transport.  
  
## Exception List  
  
|Resource Code|Resource String|  
|-------------------|---------------------|  
|MsmqActiveDirectoryRequiresNativeTransfer|The binding validation for the message failed. The client cannot send messages. A conflict in the binding properties caused this failure. The UseActiveDirectory is set to true and QueueTransferProtocol is set to Native. To resolve the conflict, correct one of the properties.|  
|MsmqAuthNoneRequiresProtectionNone|The binding validation for the service failed. The service endpoint or the client cannot be started. A conflict in the binding properties caused this failure. The MsmqAuthenticationMode is set to None and MsmqProtectionLevel is not set to None. To resolve to conflict, correct one of the properties.|  
|MsmqCustomRequiresPerAddDLQ|The binding validation for the message failed. The client cannot send the message. The DeadLetterQueue is set to Custom, but the CustomDeadLetterQueue is not specified. Specify the URI of the dead letter queue for each application in the CustomDeadLetterQueue property.|  
|MsmqDeserializationError|An error was encountered while deserializing the XML message. The message cannot be received and is dropped.|  
|MsmqDLQNotWriteable|The binding validation for the client failed. The client cannot send a message. The specified dead-letter queue does not exist or cannot be written. Ensure the queue exists with the proper authorization to write to it.|  
|MsmqGetPrivateComputerInformationError|The version check failed with the specified error. The version of MSMQ cannot be detected All operations that are on the queued channel will fail. Ensure that MSMQ is installed and is available.|  
|MsmqNoAssurancesForVolatile|The binding validation for the service failed. The service endpoint or the client cannot be started. The ExactlyOnce property is set to true and the Durable property is set to false. This is not supported. To resolve the conflict, correct one of these properties.|  
|MsmqNonTransactionalQueueNeeded|A mismatch between the binding and MSMQ queue configuration was detected. The service endpoint cannot be started. The ExactlyOnce property is set to false and the queue to read messages from is a transactional queue. Correct the error by setting the ExactlyOnce property to true or create a non-transactional binding.|  
|MsmqOpenError|An error occurred while opening the specified queue. The message cannot be sent or received from the queue. Ensure that MSMQ is installed and running. Also ensure that the queue is available to open with the required access mode and authorization.|  
|MsmqPathLookupError|An error occurred when converting the specified queue path name to the format name. All operations on the queued channel failed. Ensure that the queue address is valid. MSMQ must be installed with Active Directory integration enabled and access to it is available.|  
|MsmqPerAppDLQRequiresCustom|The binding validation on the client failed. The client cannot send messages. The CustomDeadLetterQueue property is set, but the DeadLetterQueue property is not set to Custom. Set the DeadLetterQueue property to Custom.|  
|MsmqPerAppDLQRequiresExactlyOnce|The binding validation for the client failed. The client cannot send messages. A conflict in the binding properties is causing the failure. To use the custom dead-letter queue, ExactlyOnce must be set to true to resolve to conflict.|  
|MsmqPerAppDLQRequiresMsmq4|A mismatch between the binding and MSMQ configuration was detected. The client cannot send messages. To use the custom dead-letter queue, you must have MSMQ version 4.0 or higher. If you do not have MSMQ version 4.0 or higher set the DeadLetterQueue property to System or None.|  
|MsmqReceiveError|An error occurred while receiving a message from the queue. Ensure that MSMQ is installed and running. Make sure the queue is available to receive from.|  
|MsmqSameTransactionExpected|A transaction error occurred for this session. The session channel is faulted. Messages in the session cannot be sent or received. A queued session cannot be associated with more than one transaction. Ensure that all messages in the session are sent or received using a single transaction.|  
|MsmqSendError|An error occurred while sending to the specified queue. Ensure that MSMQ is installed and running. If you are sending to a local queue, ensure the queue exists with the required access mode and authorization.|  
|MsmqTimeSpanTooLarge|The message time to live is too large. The message cannot be sent. The message Time To Live (TTL) cannot exceed the Int32 maximum value.|  
|MsmqTokenProviderNeededForCertificates|An X509SecurityTokenProvider cannot be found. The message cannot be sent. The certificate authentication mode requires an X.509 token provider. Make sure a security token provider is available for the installed certificate.|  
|MsmqTransactedDLQExpected|A mismatch occurred between the binding and the MSMQ configuration. Messages cannot be sent. The custom dead-letter queue specified in the binding must be a transaction queue. Ensure that the custom dead-letter queue address is correct and the queue is a transactional queue.|  
|MsmqTransactionalQueueNeeded|A mismatch between the binding and the MSMQ queue configuration occurred. The service endpoint cannot be started. The ExactlyOnce property is set to true and the queue to read messages from is not a transactional queue. To correct to the error, set the ExactlyOnce property to false or create a transactional queue for this binding.|  
|MsmqTransactionCurrentRequired|No transaction is available to send messages in the session. To send a message in a queued session requires a transaction. Ensure that a transaction scope is specified to send the message in the session.|  
|MsmqTransactionRequired|A transaction is required but is not available. Messages cannot be sent or received. Ensure that the transaction scope is specified to send or receive messages.|  
|MsmqUnsupportedSerializationFormat|A deserialization error occurred. The message cannot be received and is dropped. The specified serialization format is not supported.|  
|MsmqWrongPrivateQueueSyntax|The URL is invalid. The URL for the queue cannot contain the '$' character. Use the syntax in net.msmq://machine/private/queueName to address a private queue.|
