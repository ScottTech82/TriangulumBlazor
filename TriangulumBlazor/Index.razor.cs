using ICSharpCode.SharpZipLib.Zip;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace TriangulumBlazor
{
    public partial class Index
    {
        private const string DefaultStatus = "Choos a zip file";
        private List<ZipEntry> _entries;
        private string _fileName;
        private string _status = DefaultStatus;

        [Inject] private ZipService ZipService { get; set; }

        private async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            await using var stream = e.File.OpenReadStream();

            _entries = await ZipService.ExtractFiles(stream);
            _fileName = e.File.Name;
            _status = DefaultStatus;

        }
    }
}
