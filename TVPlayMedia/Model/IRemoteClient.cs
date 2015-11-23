﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using TAS.Server.Remoting;

namespace TAS.Client.Model
{
    public interface IRemoteClient
    {
        event EventHandler<WebSocketMessageEventArgs> OnMessage;
        T Query<T>(ProxyBase dto, [CallerMemberName] string methodName = "", params object[] parameters);
        void Invoke(ProxyBase dto, [CallerMemberName] string methodName = "", params object[] parameters);
        T Get<T>(ProxyBase dto, [CallerMemberName] string propertyName = "");
        void Set(ProxyBase dto, object value, [CallerMemberName] string propertyName = "");
        void EventAdd(ProxyBase dto, [CallerMemberName] string eventName = "");
        void EventRemove(ProxyBase dto, [CallerMemberName] string eventName = "");
    }
}