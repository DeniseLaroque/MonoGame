﻿// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

namespace MonoGame.Tools.Pipeline
{
    delegate void SelectionChanged();

    enum AskResult
    {
        Yes,
        No,
        Cancel
    }

    interface IView
    {
        event SelectionChanged OnSelectionChanged;

        void Attach(IController controller);

        AskResult AskSaveOrCancel();

        bool AskSaveName(ref string filePath);

        bool AskOpenProject(out string projectFilePath);

        void ShowError(string title, string message);

        void ClearTree();

        void AddTreeItem(IProjectItem item);
    }
}
