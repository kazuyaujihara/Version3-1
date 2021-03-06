﻿// ---------------------------------------------------------------------------
//  Copyright (c) 2019, The .NET Foundation.
//  This software is released under the Apache License, Version 2.0.
//  The license and further copyright text can be found in the file LICENSE.md
//  at the root directory of the distribution.
// ---------------------------------------------------------------------------

namespace Chem4Word.Core.Helpers
{
    public static class Constants
    {
        public const string Chem4WordVersion = "3.1";
        public const string Chem4WordVersionFiles = "files3-1";
        public const string ContentControlTitle = "Chemistry";
        public const string LegacyContentControlTitle = "chemistry";
        public const string NavigatorTaskPaneTitle = "Navigator";
        public const string LibraryTaskPaneTitle = "Library";

        public const double TopLeftOffset = 24;
        public const string OoXmlBookmarkPrefix = "C4W_";
        public const string LibraryFileName = "Library.db";

        public const string Chem4WordWebServiceUri = "https://chemicalservices.azurewebsites.net/api/Resolve";

        public const string DefaultEditorPlugIn = "ACME Structure Editor";
        public const string DefaultEditorPlugIn800 = "ChemDoodle Web Structure Editor 8.0.0";
        public const string DefaultEditorPlugIn702 = "ChemDoodle Web Structure Editor 7.0.2";
        public const int ChemDoodleWeb800MinimumBrowserVersion = 11;

        public const string DefaultRendererPlugIn = "Open Office Xml Renderer V4";

        // Registry Locations
        public const string Chem4WordRegistryKey = @"SOFTWARE\Chem4Word V3";

        public const string RegistryValueNameLastCheck = "Last Update Check";
        public const string RegistryValueNameVersionsBehind = "Versions Behind";
        public const string Chem4WordSetupRegistryKey = @"SOFTWARE\Chem4Word V3\Setup";
        public const string Chem4WordUpdateRegistryKey = @"SOFTWARE\Chem4Word V3\Update";

        // Update Checks
        public const int MaximunVersionsBehind = 7;
        public static string Chem4WordTooOld = "Chem4Word is too many versions old.";

        // Bond length limits etc
        public const double MinimumBondLength = 5;

        public const double StandardBondLength = 20;
        public const double MaximumBondLength = 95;
        public const double BondLengthTolerance = 1;
    }
}