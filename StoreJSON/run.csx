#r "Microsoft.WindowsAzure.Storage"

using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    string storageConnectionString = System.Environment.GetEnvironmentVariable("AzureWebJobsStorage", EnvironmentVariableTarget.Process);
    CloudStorageAccount account = CloudStorageAccount.Parse(storageConnectionString);
    CloudBlobClient client = account.CreateCloudBlobClient();
    CloudBlobContainer container = client.GetContainerReference("files");
    
    string filename = Path.GetRandomFileName();
    CloudBlockBlob blockBlob = container.GetBlockBlobReference($"{filename}.json");
    using (var stream = await req.Content.ReadAsStreamAsync())
    {
        blockBlob.UploadFromStream(stream);
    }
    string url = blockBlob.Uri.AbsoluteUri;

    return req.CreateResponse(HttpStatusCode.Created, url);
}
