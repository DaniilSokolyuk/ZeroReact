﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using JavaScriptEngineSwitcher.ChakraCore.Ext.Self;

namespace JavaScriptEngineSwitcher.ChakraCore.JsRt
{
    internal partial struct JsContext
    {
        public static unsafe JsValue RunScriptUtf16Buffer(
            ref PooledCharBuffer scriptBuffer,
            JsSourceContext sourceContext,
            PooledCharBuffer sourceUrl)
        {
            //pin memory for preserve GC move memory when execute script
            fixed (char* scriptBufferPtr = scriptBuffer.Array)
            fixed (char* sourceUrlPtr = sourceUrl.Array)
            {
                JsErrorHelpers.ThrowIfError(NativeMethods.JsCreateStringUtf16((IntPtr)scriptBufferPtr, (uint)scriptBuffer.Length, out var scriptValue));
                scriptValue.AddRef();

                JsErrorHelpers.ThrowIfError(NativeMethods.JsCreateStringUtf16((IntPtr)sourceUrlPtr, (uint)sourceUrl.Length, out var sourceUrlValue));
                sourceUrlValue.AddRef();

                JsValue result;

                try
                {
                    JsErrorHelpers.ThrowIfError(NativeMethods.JsRun(scriptValue, sourceContext, sourceUrlValue, JsParseScriptAttributes.None, out result));
                }
                finally
                {
                    scriptValue.Release();
                    sourceUrlValue.Release();
                }

                return result;
            }
        }
    }
}
