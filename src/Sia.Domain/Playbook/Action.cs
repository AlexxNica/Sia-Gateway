﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sia.Domain.Playbook
{
    public class Action
    {
        public long Id { get; set; }
        public bool IsUrl { get; set; }
        public ActionTemplate ActionTemplate { get; set; }
        public ICollection<ConditionSet> ConditionSets { get; set; }
            = new List<ConditionSet>();
    }
}