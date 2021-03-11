﻿using CoronaDeployments.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaDeployments.Core.Models.Mvc
{
    public sealed class ProjectUpdateModel : IValidatableObject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RepositoryUrl { get; set; }
        public SourceCodeRepositoryType RepositoryType { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return new ValidationResult[0];
        }
    }
}
