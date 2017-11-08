/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace PHC.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('PHC');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}