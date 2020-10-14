namespace TreeView.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Microsoft.Extensions.Logging;

    using System.Diagnostics;
    using System.Collections.Generic;

    using TreeView.Models;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> Logger;

        public HomeController(ILogger<HomeController> Logger)
        {
            this.Logger = Logger;
        }

        public IActionResult Index()
        {
            List<File> Files = new List<File>()
            {
                new File()
                {
                    Name = "Controllers",
                    Description = "Accepts input and converts it to commands for the model or view",
                    Childs = new List<File>()
                    {
                        new File()
                        {
                            Name = "HomeController.cs"
                        }
                    }
                },
                new File()
                {
                    Name = "Models",
                    Description = "The central component of the pattern. It is the application's dynamic data structure, independent of the user interface",
                    Childs = new List<File>()
                    {
                        new File()
                        {
                            Name = "File.cs"
                        }
                    }
                },
                new File()
                {
                    Name = "Views",
                    Description = "Any representation of information such as a chart, diagram or table. Multiple views of the same information are possible, such as a bar chart for management and a tabular view for accountants.",
                    Childs = new List<File>()
                    {
                        new File()
                        {
                            Name = "Home",
                            Childs = new List<File>()
                            {
                                new File()
                                {
                                    Name = "Index.cshtml"
                                }
                            }
                        },
                        new File()
                        {
                            Name = "Shared",
                            Childs = new List<File>()
                            {
                                new File()
                                {
                                    Name = "Components",
                                    Childs = new List<File>()
                                    {
                                        new File()
                                        {
                                            Name = "TreeView",
                                            Childs = new List<File>()
                                            {
                                                new File()
                                                {
                                                    Name = "Default.cshtml"
                                                }
                                            }
                                        },
                                        new File()
                                        {
                                            Name = "TreeViewItem",
                                            Childs = new List<File>()
                                            {
                                                new File()
                                                {
                                                    Name = "Default.cshtml"
                                                }
                                            }
                                        }
                                    }
                                },
                                new File()
                                {
                                    Name = "_Layout.cshtml"
                                },
                                new File()
                                {
                                    Name = "Error.cshtml"
                                }
                            }
                        },
                        new File()
                        {
                            Name = "_ViewImports.cshtml"
                        },
                        new File()
                        {
                            Name = "_ViewStart.cshtml"
                        }
                    }
                },
                new File()
                {
                    Name = "appsettings.json"
                },
                new File()
                {
                    Name = "aspcore-tree-view.csproj"
                },
                new File()
                {
                    Name = "Program.cs"
                },
                new File()
                {
                    Name = "Startup.cs"
                }
            };

            return View(Files);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

    }
}
