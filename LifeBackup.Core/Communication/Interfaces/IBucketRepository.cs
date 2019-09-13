using LifeBackup.Core.Communication.Bucket;
using System.Threading.Tasks;

namespace LifeBackup.Core.Communication.Interfaces
{
    public interface IBucketRepository
    {
        Task<bool> DoesS3BucketExist(string bucketName);
        Task<CreateBucketResponse> CreateBucket(string bucketName);
    }
}
