#region License GNU GPL
// TrustCertificate.cs
// 
// Copyright (C) 2012 - BehaviorIsManaged
// 
// This program is free software; you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free Software Foundation;
// either version 2 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details. 
// You should have received a copy of the GNU General Public License along with this program; 
// if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
    public class TrustCertificate
    {
        public const short Id = 377;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int id;
        public string hash;
        
        public TrustCertificate()
        {
        }
        
        public TrustCertificate(int id, string hash)
        {
            this.id = id;
            this.hash = hash;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(id);
            writer.WriteUTF(hash);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadInt();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            hash = reader.ReadUTF();
        }
        
    }
    
}