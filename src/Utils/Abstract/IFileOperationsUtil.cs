using System.Threading.Tasks;

namespace Soenneker.Runners.Email.Disposables.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(string filePath);
}
