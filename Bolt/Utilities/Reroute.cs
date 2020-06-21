﻿using Bolt;
using Ludiq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lasm.BoltExtensions
{
    public class Reroute : Unit
    {
        [DoNotSerialize][PortLabelHidden]
        public ValueInput input;
        [DoNotSerialize][PortLabelHidden]
        public ValueOutput output;
        public Type portType = typeof(object);

        protected override void Definition()
        {
            input = ValueInput(portType, "in");
            output = ValueOutput(portType, "out");
        }
    }
}