using iMessenger.Contract;
using iMessenger.Contract.Models;
using iMessenger.Helpers;

namespace iMessenger;

public class RGDialogsClientsService : IRGDialogsClientsService
{
    private readonly List<RGDialogsClients> context;

    public RGDialogsClientsService()
    {
        context = RGDialogsClientsHelper.Init();
    }

    public async Task<object> Get(
    string[] ids)
    {
        if (context.Count == 0 || ids.Length == 0)
        {
            return new Guid();
        }

        var dialogIds = RGDialogsClientsHelper.GetDialogIds(context, ids);

        if (dialogIds.Count == 0)
        {
            return new Guid();
        }

        var sortDialogIds = RGDialogsClientsHelper.GetUniqueDialogIds(dialogIds);

        if (dialogIds.Count > 1)
        {
            foreach (var dialogId in dialogIds)
            {
                sortDialogIds = sortDialogIds.Intersect(dialogId).ToList();
            }
        }

        if (sortDialogIds.Count != 0)
        {
            return sortDialogIds[0];
        }

        return new Guid();
    }
}