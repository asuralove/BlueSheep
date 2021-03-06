









// Generated on 12/11/2014 19:01:51
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeObjectUseInWorkshopMessage : Message
    {
        public new const uint ID =6004;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int objectUID;
        public int quantity;
        
        public ExchangeObjectUseInWorkshopMessage()
        {
        }
        
        public ExchangeObjectUseInWorkshopMessage(int objectUID, int quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarInt(objectUID);
            writer.WriteVarInt(quantity);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            objectUID = reader.ReadVarInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVarInt();
        }
        
    }
    
}