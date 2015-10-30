﻿using System;
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Balakin.VSColorfullOutput.BuildOutput.Formats {
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "BuildFailed")]
    [Name("BuildFailed")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class BuildFailedClassifierFormat : ClassificationFormatDefinition {
        [ImportingConstructor]
        public BuildFailedClassifierFormat(ColorManager colorManager) {
            DisplayName = "Build failed";
            ForegroundColor = colorManager.ErrorColor;
        }
    }
}
