﻿//
//  WorldLODMapAreaHoles.cs
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

using System.Collections.Generic;
using System.IO;
using Warcraft.Core.Interfaces;

namespace Warcraft.WDL.Chunks
{
    public class WorldLODMapAreaHoles : IIFFChunk, IBinarySerializable
    {
        /// <summary>
        /// Holds the binary chunk signature.
        /// </summary>
        public const string Signature = "MAHO";

        public readonly List<short> HoleMasks = new List<short>();

        public bool IsEmpty
        {
            get
            {
                return HoleMasks.TrueForAll(sh => sh == 0);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldLODMapAreaHoles"/> class.
        /// </summary>
        public WorldLODMapAreaHoles()
        {
        }

        public WorldLODMapAreaHoles(byte[] inData)
        {
            LoadBinaryData(inData);
        }

        /// <inheritdoc/>
        public void LoadBinaryData(byte[] inData)
        {
            using (MemoryStream ms = new MemoryStream(inData))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    for (int i = 0; i < 16; ++i)
                    {
                        HoleMasks.Add(br.ReadInt16());
                    }
                }
            }
        }

        public static int GetSize()
        {
            return 16 * sizeof(short);
        }

        /// <inheritdoc/>
        public string GetSignature()
        {
            return Signature;
        }

        /// <summary>
        /// Creates an empty hole chunk, where all values are set to 0.
        /// </summary>
        /// <returns>An empty chunk.</returns>
        public static WorldLODMapAreaHoles CreateEmpty()
        {
            return new WorldLODMapAreaHoles(new byte[32]);
        }

        /// <inheritdoc/>
        public byte[] Serialize()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter bw = new BinaryWriter(ms))
                {
                    foreach (short holeMask in HoleMasks)
                    {
                        bw.Write(holeMask);
                    }
                }

                return ms.ToArray();
            }
        }
    }
}

