using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Alexa.NET.Response.Directive;


namespace Alexa.NET.Response.Converters
{
    public class DirectiveConverter : TypeJsonConverter<IDirective>
    {
        public static Dictionary<string, Func<IDirective>> TypeFactories = new Dictionary<string, Func<IDirective>>
        {
            { "AudioPlayer.Play", () => new AudioPlayerPlayDirective() },
            { "AudioPlayer.ClearQueue", () => new ClearQueueDirective() },
            { "Dialog.ConfirmIntent", () => new DialogConfirmIntent() },
            { "Dialog.ConfirmSlot", () => new DialogConfirmSlot() },
            { "Dialog.Delegate", () => new DialogDelegate() },
            { "Dialog.ElicitSlot", () => new DialogElicitSlot() },
            { "Display.RenderTemplate", () => new DisplayRenderTemplateDirective() },
            { "Hint", () => new HintDirective() },
            { "AudioPlayer.Stop", () => new StopDirective() },
            { "VideoApp.Launch", () => new VideoAppDirective() },
            { "Connections.StartConnection", () => new StartConnectionDirective() },
            { "Tasks.CompleteTask",() => new CompleteTaskDirective()},
            { "Dialog.UpdateDynamicEntities", () => new DialogUpdateDynamicEntities() }
        };

        public DirectiveConverter() : base(TypeFactories)
        {
        }
    }
}