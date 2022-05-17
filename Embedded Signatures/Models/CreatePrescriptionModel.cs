﻿using Microsoft.AspNetCore.Mvc.Rendering;
namespace Embedded_Signatures.Models
{
    public class CreatePrescriptionModel
    {
        public string PatientName { get; set; }
        public string MedicationName { get; set; }

        public string? EmbedUrl { get; set; }

        public string? JavascriptToRun { get; set; }
   
    }
}
