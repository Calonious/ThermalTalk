﻿namespace ThermalTalk
{
    using System.Collections.Generic;

    public class StandardDocument : IDocument
    {
        public StandardDocument()
        {
            Sections = new List<ISection>();
        }

        public virtual IList<ISection> Sections { get; set; }
    }
}
