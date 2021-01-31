using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        // constructor
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        // properties
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();      //call local Validate()

        public abstract bool Validate();    // cannot call Validate in other class from here 
                                            // so defined a 'local' Validate()        

        
    }
}
