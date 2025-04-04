// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

namespace Wpf.Ui.Gallery.ViewModels.Pages.Collections;

public partial class ListBoxViewModel : ViewModel
{
    [ObservableProperty]
    private ObservableCollection<string> _listBoxItems =
    [
        "Arial",
        "Comic Sans MS",
        "Courier New",
        "Segoe UI",
        "Times New Roman",
    ];
}
