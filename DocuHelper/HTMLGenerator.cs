using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siemens.Engineering.SW.Blocks;
using System.Xml;

namespace DocuHelper
{

    public static class GrollmusData
    {
        public static string logo()
        {
            return @"
<svg version = ""1.1"" id=""Ebene_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
	 viewBox=""0 0 534.29 65.34"" style=""enable-background:new 0 0 534.29 65.34; width: 534px; height: 65px"" xml:space=""preserve"">
<style type = ""text/css"" >

    .st0{fill:#0669b3;}
</style>
<g>
	<path class=""st0"" d=""M129.76,23.45C129.76,8.48,120.76,1,102.75,1H72.73v63.25h15.7V45.89h11.8l14.87,18.43l17.73,0.04l-16.5-20.45
		C125.28,40.8,129.76,33.99,129.76,23.45z M88.43,14.36h13.1c4.2,0,7.3,0.71,9.29,2.13c1.99,1.42,2.98,3.8,2.98,7.13
		c0,3.28-0.99,5.63-2.98,7.05c-1.99,1.42-5.08,2.13-9.29,2.13h-13.1V14.36z""/>
	<path class=""st0"" d=""M529.61,31.52c-3.12-2.89-7.85-4.69-14.2-5.42l-7.13-0.7c-4.76-0.52-8.03-1.2-9.81-2.04
		c-1.78-0.84-2.67-2.39-2.67-4.65c0-2.18,0.95-3.65,2.85-4.44c1.9-0.78,5.02-1.17,9.38-1.17c6.52,0.03,13.79,0.3,21.79,0.83V2.52
		C523.6,0.84,516.36,0,508.1,0c-19.32,0-28.97,6.48-28.97,19.44c0,11.11,6.35,17.34,19.05,18.71l7.14,0.78
		c4.81,0.61,8.08,1.33,9.81,2.15c1.73,0.83,2.59,2.43,2.59,4.81c0,2.2-1.07,3.78-3.2,4.72c-2.13,0.94-5.43,1.41-9.9,1.41
		c-7.31,0-15.36-0.26-24.14-0.78v11.4c6.06,1.74,14.08,2.61,24.06,2.61c19.84,0,29.76-6.68,29.76-20.05
		C534.29,38.96,532.73,34.4,529.61,31.52z""/>
	<path class=""st0"" d=""M454.67,37.63c0,9.19-4.51,13.79-13.53,13.79c-9.02,0-13.53-4.6-13.53-13.79V1h-15.88v37.32
		c0,8.9,2.46,15.63,7.4,20.18c4.93,4.55,12.2,6.83,21.82,6.83c9.61,0,16.91-2.28,21.88-6.83c4.97-4.55,7.46-11.28,7.46-20.18V1

        h-15.62V37.63z""/>
	<path class=""st0"" d=""M45.9,49.9c-3.39,0.72-6.7,1.09-9.92,1.09c-6.12,0-10.93-1.61-14.42-4.83c-3.5-3.22-5.24-7.55-5.24-13.01
		c0-12.65,7.54-18.97,22.62-18.97c7.11,0,13.49,0.23,19.14,0.7V2.52C51.43,0.84,44.37,0,36.89,0C25.12,0,16.02,3.02,9.61,9.05
		C3.2,15.08,0,23.11,0,33.15c0,9.34,2.99,17,8.96,22.99c5.97,5.99,13.38,8.98,22.23,8.98c6.23,0.03,11.25-1.74,15.05-5.31h1.44
		l0.87,4.44H61.3V29.84H45.9V49.9z""/>
	<polygon class=""st0"" points=""363.8,28.28 362.53,28.28 346.4,1 325.91,1 325.91,64.25 341.52,64.25 341.52,21.14 343.57,21.14 
		359.97,48.29 365.93,48.29 382.33,21.14 384.37,21.14 384.37,64.25 400.12,64.25 400.12,1 379.98,1 	""/>
	<polygon class=""st0"" points=""229.78,1 214.08,1 214.08,64.25 263.54,64.25 263.54,50.72 229.78,50.72 	""/>
	<polygon class=""st0"" points=""285.7,1 269.99,1 269.99,64.25 319.45,64.25 319.45,50.72 285.7,50.72 	""/>
</g>
<path class=""st0"" d=""M170.48,0c-18.04,0-32.67,14.63-32.67,32.67c0,18.04,14.63,32.67,32.67,32.67c18.04,0,32.67-14.63,32.67-32.67
	C203.15,14.63,188.53,0,170.48,0z M177.57,47.77c-10.74,0-19.44-8.7-19.44-19.44c0-10.74,8.71-19.44,19.44-19.44
	s19.44,8.71,19.44,19.44C197.01,39.06,188.31,47.77,177.57,47.77z""/>
</svg>
            ";
        }

        public static string header()
        {
            return @"
<html>
<head>
    <title>Grollmus Library</title>
    <style>
        body {
            font-family: sans-serif;
            font-size: 12pt;
            width: 80%;
            }
        h1, h2, h3, h4 {
            font-family: sans-serif;
            }
        .small {
            font-size: 8pt;
            }
    </style>
</head>
<body>
            ";
        }

        public static string footer()
        {
            return $@"
    <p class=""small"">Dokumentation am {DateTime.Now} mit viel Liebe erstellt</p>
</body>
</html>
";
        }
    }
    public class HomeGenerator
    {
        private List<string> types;
        public HomeGenerator(List<string> types)
        {
            this.types = types;
        }

        private string typeList => string
            .Concat(types.Select(_ => $"<li><a href=\"Library Types\\{_}.htm\">{_}</a></li>"));

        public string Result => $@"
{GrollmusData.header()}
    {GrollmusData.logo()}
    <h1>Grollmus Library</h1>
    <ul>
        {typeList}
    </ul>
{GrollmusData.footer()}
";
    }
    public class HTMLGenerator
    {
        private readonly string name;
        private readonly string author;
        private readonly Guid typeGuid;
        private List<TypeVersion> typeVersions;
        private readonly string blockComment;


        public HTMLGenerator(CodeBlockLibraryType codeBlockLibraryType)
        {
            name = codeBlockLibraryType.Name;
            author = codeBlockLibraryType.Author;
            typeGuid = codeBlockLibraryType.Guid;
            blockComment = codeBlockLibraryType.Comment.Items.First().Text;
            typeVersions = new List<TypeVersion>();

            foreach (CodeBlockLibraryTypeVersion libraryTypeVersion in codeBlockLibraryType.Versions)
            {
                typeVersions.Add(new TypeVersion() 
                { 
                    version = libraryTypeVersion.VersionNumber.ToString(),
                    date = libraryTypeVersion.ModifiedDate.ToString(),
                    author = libraryTypeVersion.Author.ToString(),
                    guid = libraryTypeVersion.Guid,
                    comment = libraryTypeVersion.Comment.Items.First().Text

                } );

            }
            typeVersions.Reverse();

        }

        private string versionList => string
            .Concat(typeVersions.Select(_ => $"<tr><td>{_.version}</td><td>{_.author}</td><td>{_.date}</td><td>{_.comment} ({_.guid.ToString()})</td></tr>"));

        public string Result => $@"
{GrollmusData.header()}
    {GrollmusData.logo()}
    <p><a href=""../home.htm"">Zurück</a></p>
    <h1>{name}</h1>
    <p>{blockComment}</p>
    <p>Author: {author}</p>
    <p>GUID: {typeGuid.ToString()}</p>
    <h2>1 Structure</h2>
    <h2>2 Documentation</h2>
    <h2>3 Library Data</h2>
    <table>
        <tr>
            <td>Version</td>
            <td>Author</td>
            <td>Modified</td>
            <td>Comment</td>
        </tr>
        {versionList}
    </table>
{GrollmusData.footer()} 
";
    }
}
