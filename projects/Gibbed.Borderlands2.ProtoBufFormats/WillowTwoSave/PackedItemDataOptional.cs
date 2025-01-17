﻿/* Copyright (c) 2019 Rick (rick 'at' gibbed 'dot' us)
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System;
using System.ComponentModel;
using ProtoBuf;

namespace Gibbed.Borderlands2.ProtoBufFormats.WillowTwoSave
{
    [ProtoContract]
    public class PackedItemDataOptional : INotifyPropertyChanged
    {
        #region Fields
        private byte[] _InventorySerialNumber;
        private int _Quantity;
        private bool _Equipped;
        private PlayerMark _Mark;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public byte[] InventorySerialNumber
        {
            get { return this._InventorySerialNumber; }
            set
            {
                if (value != this._InventorySerialNumber)
                {
                    this._InventorySerialNumber = value;
                    this.NotifyOfPropertyChange(nameof(InventorySerialNumber));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public int Quantity
        {
            get { return this._Quantity; }
            set
            {
                if (value != this._Quantity)
                {
                    this._Quantity = value;
                    this.NotifyOfPropertyChange(nameof(Quantity));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public bool Equipped
        {
            get { return this._Equipped; }
            set
            {
                if (value != this._Equipped)
                {
                    this._Equipped = value;
                    this.NotifyOfPropertyChange(nameof(Equipped));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public PlayerMark Mark
        {
            get { return this._Mark; }
            set
            {
                if (value != this._Mark)
                {
                    this._Mark = value;
                    this.NotifyOfPropertyChange(nameof(Mark));
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
