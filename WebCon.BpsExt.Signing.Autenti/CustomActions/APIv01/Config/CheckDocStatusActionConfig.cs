﻿using WebCon.BpsExt.Signing.Autenti.CustomActions.APIv01.Config;
using WebCon.WorkFlow.SDK.Common;
using WebCon.WorkFlow.SDK.ConfigAttributes;

namespace WebCon.BpsExt.Signing.Autenti.CustomActions.APIv1.Status
{
    public class CheckDocStatusActionConfig : PluginConfiguration
    {
        [ConfigGroupBox(DisplayName = "Autenti API Settings")]
        public ApiConfiguration ApiConfig { get; set; }

        [ConfigEditableFormFieldID(DisplayName = "Document ID", Description = "Select the text field where the Document ID was saved")]
        public int DokFildId { get; set; }

        [ConfigEditableFormFieldID(DisplayName = "Copy Status to field", Description = "Specify a field on the form where current document status will be saved")]
        public int StatusFildId { get; set; }
    }   
}