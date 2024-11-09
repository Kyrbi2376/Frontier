﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._NF.ShuttleRecords.UI;

[GenerateTypedNameReferences]
public sealed partial class ShuttleRecordListItem : Button
{
    public sealed class ViewState(string shuttleName, string toolTip = "", bool disabled = false)
    {
        public string ShuttleName { get; } = shuttleName;

        public bool Disabled { get; } = disabled;

        public string ToolTip { get; } = toolTip;
    }

    public ShuttleRecordListItem(ViewState state)
    {
        RobustXamlLoader.Load(this);
        ShuttleName.Text = state.ShuttleName;
        ToolTip = state.ToolTip;
        Disabled = state.Disabled;
    }
}
