﻿using TreeView.Models;

namespace TreeView.Components
{
    using Microsoft.AspNetCore.Mvc;

    using System.Collections.Generic;

    public class TreeView : ViewComponent
    {
        public IViewComponentResult Invoke(List<File> Files) => View(Files);
    }
}
