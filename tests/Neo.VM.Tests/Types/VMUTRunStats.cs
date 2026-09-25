// Copyright (C) 2015-2026 The Neo Project.
//
// VMUTRunStats.cs file belongs to the neo project and is free
// software distributed under the MIT software license, see the
// accompanying file LICENSE in the main directory of the
// repository or http://www.opensource.org/licenses/mit-license.php
// for more details.
//
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

using Neo.VM.Types;
using Newtonsoft.Json;

namespace Neo.Test.Types;

public class VMUTRunStats
{
    [JsonProperty]
    public StackItemType? Type { get; set; }

    [JsonProperty]
    public int? Length { get; set; }

    [JsonProperty]
    public int? RefsDelta { get; set; }

    [JsonProperty]
    public int? NClonedItems { get; set; }
}
