﻿namespace TemplateProject.Application.Common;

public interface IClock
{
    DateTime UtcNow { get; }
}