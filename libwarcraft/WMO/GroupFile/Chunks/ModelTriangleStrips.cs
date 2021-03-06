//
//  ModelTriangleStrips.cs
//
//  Copyright (c) 2018 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.IO;
using Warcraft.Core.Interfaces;

namespace Warcraft.WMO.GroupFile.Chunks
{
    public class ModelTriangleStrips : IIFFChunk, IBinarySerializable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTriangleStrips"/> class.
        /// </summary>
        public ModelTriangleStrips()
        {
        }

        /// <inheritdoc/>
        public void LoadBinaryData(byte[] inData)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public string GetSignature()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public byte[] Serialize()
        {
            throw new NotImplementedException();
        }
    }

    public class TriangleStrip : IBinarySerializable
    {
        public uint StartTriangleIndex;
        public ushort TriangleIndexCount;

        public TriangleStrip(byte[] inData)
        {
            using (MemoryStream ms = new MemoryStream(inData))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    StartTriangleIndex = br.ReadUInt32();
                    TriangleIndexCount = br.ReadUInt16();
                }
            }
        }

        /// <inheritdoc/>
        public byte[] Serialize()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter bw = new BinaryWriter(ms))
                {
                    bw.Write(StartTriangleIndex);
                    bw.Write(TriangleIndexCount);

                    // Then a bit of padding
                    bw.Write((ushort)0);
                }

                return ms.ToArray();
            }
        }
    }
}

