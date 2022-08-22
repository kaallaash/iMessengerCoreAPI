﻿using iMessenger.Contract.Models;

namespace iMessenger.Helpers;

public static class RGDialogsClientsHelper
{
    public static List<RGDialogsClients> Init()
    {
        var L1 = new List<RGDialogsClients>();

        var IDClient1 = new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151");
        var IDClient2 = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820");
        var IDClient3 = new Guid("7de3299b-2796-4982-a85b-2d6d1326396e");
        var IDClient4 = new Guid("0a58955e-342f-4095-88c6-1109d0f70583");
        var IDClient5 = new Guid("50454d55-a73c-4cbc-be25-3c5729dcb82b");

        var IDRGDialog1 = new Guid("fcd6b112-1834-4420-bee6-70c9776f6378");

        L1.Add(new RGDialogsClients
        {
            IDUnique = Guid.NewGuid(),
            IDRGDialog = IDRGDialog1,
            IDClient = IDClient1
        });

        L1.Add(new RGDialogsClients
        {
            IDUnique = Guid.NewGuid(),
            IDRGDialog = IDRGDialog1,
            IDClient = IDClient2
        });

        L1.Add(new RGDialogsClients
        {
            IDUnique = Guid.NewGuid(),
            IDRGDialog = IDRGDialog1,
            IDClient = IDClient3
        });

        var IDRGDialog2 = new Guid("19f6f751-7f8d-41fa-8261-709028650592");

        L1.Add(new RGDialogsClients
        {
            IDUnique = Guid.NewGuid(),
            IDRGDialog = IDRGDialog2,
            IDClient = IDClient1
        });

        L1.Add(new RGDialogsClients
        {
            IDUnique = Guid.NewGuid(),
            IDRGDialog = IDRGDialog2,
            IDClient = IDClient2
        });

        var IDRGDialog3 = new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f");

        L1.Add(new RGDialogsClients
        {
            IDUnique = Guid.NewGuid(),
            IDRGDialog = IDRGDialog3,
            IDClient = IDClient3
        });

        L1.Add(new RGDialogsClients
        {
            IDUnique = Guid.NewGuid(),
            IDRGDialog = IDRGDialog3,
            IDClient = IDClient4
        });

        L1.Add(new RGDialogsClients
        {
            IDUnique = Guid.NewGuid(),
            IDRGDialog = IDRGDialog3,
            IDClient = IDClient5
        });

        return L1;
    }

    public static List<Guid> GetUniqueDialogIds(List<List<Guid>> dialogIds)
    {
        var sortDialogIds = new List<Guid>();

        foreach (var dialogId in dialogIds)
        {
            foreach (var id in dialogId)
            {
                sortDialogIds.Add(id);
            }
        }

        return sortDialogIds.Distinct().ToList();
    }

    public static List<List<Guid>> GetDialogIds(
    List<RGDialogsClients> context,
    string[] ids)
    {
        var dialogIds = new List<List<Guid>>();

        foreach (var id in ids)
        {
            dialogIds.Add(context
               .Where(d => d.IDClient.ToString() == id)
               .Select(d => d.IDRGDialog)
               .ToList());
        }

        return dialogIds;
    }
}
