using System.Threading.Tasks;

namespace Soenneker.Runners.Email.Disposables.Utils.Abstract;

public interface IDownloadUtil
{
    ValueTask<string> Download();
}
