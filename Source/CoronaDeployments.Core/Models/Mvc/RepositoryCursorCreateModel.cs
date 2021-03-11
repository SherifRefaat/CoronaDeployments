﻿using CoronaDeployments.Core.RepositoryImporter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaDeployments.Core.Models.Mvc
{
    public class RepositoryCursorCreateModel
    {
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public RepositoryCommit Selected { get; set; }
        public List<RepositoryCommit> Commits { get; set; }
    }
}
