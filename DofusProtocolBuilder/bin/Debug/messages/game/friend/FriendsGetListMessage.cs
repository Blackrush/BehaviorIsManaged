

// Generated on 10/25/2012 10:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Protocol.Types;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
    public class FriendsGetListMessage : NetworkMessage
    {
        public const uint Id = 4001;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public FriendsGetListMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}