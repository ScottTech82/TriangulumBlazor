namespace TriangulumBlazor
{
    public class ZipService
    {
        public async Task<List<ZipEntry>> ExtractFiles(Stream fileData)
        {
            await using var ms = new MemoryStream();
            await fileData.CopyToAsync(ms);
        }
    }
}
