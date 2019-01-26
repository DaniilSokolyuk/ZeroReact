﻿using System;
using System.Runtime.InteropServices;

using JavaScriptEngineSwitcher.ChakraCore.Constants;

namespace JavaScriptEngineSwitcher.ChakraCore.JsRt
{
	/// <summary>
	/// Native methods
	/// </summary>
	internal static partial class NativeMethods
	{
		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateRuntime(JsRuntimeAttributes attributes,
			JsThreadServiceCallback threadService, out JsRuntime runtime);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCollectGarbage(JsRuntime handle);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsDisposeRuntime(JsRuntime handle);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetRuntimeMemoryUsage(JsRuntime runtime, out UIntPtr memoryUsage);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetRuntimeMemoryLimit(JsRuntime runtime, out UIntPtr memoryLimit);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetRuntimeMemoryLimit(JsRuntime runtime, UIntPtr memoryLimit);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetRuntimeMemoryAllocationCallback(JsRuntime runtime,
			IntPtr callbackState, JsMemoryAllocationCallback allocationCallback);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetRuntimeBeforeCollectCallback(JsRuntime runtime, IntPtr callbackState,
			JsBeforeCollectCallback beforeCollectCallback);

		[DllImport(DllName.Universal, EntryPoint = "JsAddRef")]
		internal static extern JsErrorCode JsContextAddRef(JsContext reference, out uint count);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsAddRef(JsValue reference, out uint count);

		[DllImport(DllName.Universal, EntryPoint = "JsRelease")]
		internal static extern JsErrorCode JsContextRelease(JsContext reference, out uint count);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsRelease(JsValue reference, out uint count);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetObjectBeforeCollectCallback(JsValue reference, IntPtr callbackState,
			JsObjectBeforeCollectCallback beforeCollectCallback);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateContext(JsRuntime runtime, out JsContext newContext);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetCurrentContext(out JsContext currentContext);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetCurrentContext(JsContext context);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetContextOfObject(JsValue obj, out JsContext context);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetContextData(JsContext context, out IntPtr data);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetContextData(JsContext context, IntPtr data);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetRuntime(JsContext context, out JsRuntime runtime);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsIdle(out uint nextIdleTick);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetSymbolFromPropertyId(JsPropertyId propertyId, out JsValue symbol);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetPropertyIdType(JsPropertyId propertyId,
			out JsPropertyIdType propertyIdType);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetPropertyIdFromSymbol(JsValue symbol, out JsPropertyId propertyId);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateSymbol(JsValue description, out JsValue symbol);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetOwnPropertySymbols(JsValue obj, out JsValue propertySymbols);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetUndefinedValue(out JsValue undefinedValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetNullValue(out JsValue nullValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetTrueValue(out JsValue trueValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetFalseValue(out JsValue falseValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsBoolToBoolean(bool value, out JsValue booleanValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsBooleanToBool(JsValue booleanValue, out bool boolValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsConvertValueToBoolean(JsValue value, out JsValue booleanValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetValueType(JsValue value, out JsValueType type);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsDoubleToNumber(double doubleValue, out JsValue value);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsIntToNumber(int intValue, out JsValue value);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsNumberToDouble(JsValue value, out double doubleValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsNumberToInt(JsValue value, out int intValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsConvertValueToNumber(JsValue value, out JsValue numberValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetStringLength(JsValue sringValue, out int length);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsConvertValueToString(JsValue value, out JsValue stringValue);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetGlobalObject(out JsValue globalObject);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateObject(out JsValue obj);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateExternalObject(IntPtr data,
			JsFinalizeCallback finalizeCallback, out JsValue obj);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsConvertValueToObject(JsValue value, out JsValue obj);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetPrototype(JsValue obj, out JsValue prototypeObject);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetPrototype(JsValue obj, JsValue prototypeObject);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsInstanceOf(JsValue obj, JsValue constructor, out bool result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetExtensionAllowed(JsValue obj, out bool value);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsPreventExtension(JsValue obj);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetProperty(JsValue obj, JsPropertyId propertyId, out JsValue value);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetOwnPropertyDescriptor(JsValue obj, JsPropertyId propertyId,
			out JsValue propertyDescriptor);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetOwnPropertyNames(JsValue obj, out JsValue propertyNames);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetProperty(JsValue obj, JsPropertyId propertyId, JsValue value,
			bool useStrictRules);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsHasProperty(JsValue obj, JsPropertyId propertyId, out bool hasProperty);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsHasOwnProperty(JsValue obj, JsPropertyId propertyId, out bool hasOwnProperty);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsDeleteProperty(JsValue obj, JsPropertyId propertyId, bool useStrictRules,
			out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsDefineProperty(JsValue obj, JsPropertyId propertyId,
			JsValue propertyDescriptor, out bool result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsHasIndexedProperty(JsValue obj, JsValue index, out bool result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetIndexedProperty(JsValue obj, JsValue index, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetIndexedProperty(JsValue obj, JsValue index, JsValue value);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsDeleteIndexedProperty(JsValue obj, JsValue index);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsHasIndexedPropertiesExternalData(JsValue obj, out bool value);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetIndexedPropertiesExternalData(JsValue obj, IntPtr data,
			out JsTypedArrayType arrayType, out uint elementLength);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetIndexedPropertiesToExternalData(JsValue obj, IntPtr data,
			JsTypedArrayType arrayType, uint elementLength);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsEquals(JsValue obj1, JsValue obj2, out bool result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsStrictEquals(JsValue obj1, JsValue obj2, out bool result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsHasExternalData(JsValue obj, out bool value);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetExternalData(JsValue obj, out IntPtr externalData);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetExternalData(JsValue obj, IntPtr externalData);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateArray(uint length, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateArrayBuffer(uint byteLength, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateExternalArrayBuffer(IntPtr data, uint byteLength,
			JsFinalizeCallback finalizeCallback, IntPtr callbackState, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateTypedArray(JsTypedArrayType arrayType, JsValue arrayBuffer,
			uint byteOffset, uint elementLength, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateDataView(JsValue arrayBuffer, uint byteOffset,
			uint byteOffsetLength, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetTypedArrayInfo(JsValue typedArray, out JsTypedArrayType arrayType,
			out JsValue arrayBuffer, out uint byteOffset, out uint byteLength);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetArrayBufferStorage(JsValue arrayBuffer, out IntPtr buffer,
			out uint bufferLength);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetTypedArrayStorage(JsValue typedArray, out byte[] buffer,
			out uint bufferLength, out JsTypedArrayType arrayType, out int elementSize);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetDataViewStorage(JsValue dataView, out byte[] buffer,
			out uint bufferLength);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCallFunction(JsValue function, JsValue[] arguments,
			ushort argumentCount, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsConstructObject(JsValue function, JsValue[] arguments,
			ushort argumentCount, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateFunction(JsNativeFunction nativeFunction, IntPtr externalData,
			out JsValue function);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateNamedFunction(JsValue name, JsNativeFunction nativeFunction,
			IntPtr callbackState, out JsValue function);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateError(JsValue message, out JsValue error);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateRangeError(JsValue message, out JsValue error);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateReferenceError(JsValue message, out JsValue error);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateSyntaxError(JsValue message, out JsValue error);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateTypeError(JsValue message, out JsValue error);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCreateURIError(JsValue message, out JsValue error);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsHasException(out bool hasException);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetAndClearException(out JsValue exception);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsGetAndClearExceptionWithMetadata(out JsValue metadata);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetException(JsValue exception);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsDisableRuntimeExecution(JsRuntime runtime);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsEnableRuntimeExecution(JsRuntime runtime);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsIsRuntimeExecutionDisabled(JsRuntime runtime, out bool isDisabled);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSetPromiseContinuationCallback(
			JsPromiseContinuationCallback promiseContinuationCallback, IntPtr callbackState);

		#region Hosting

		[DllImport(DllName.Universal, CharSet = CharSet.Ansi)]
		internal static extern JsErrorCode JsCreateString(string content, UIntPtr length, out JsValue value);

		[DllImport(DllName.Universal, CharSet = CharSet.Unicode)]
		internal static extern JsErrorCode JsCreateStringUtf16(string content, UIntPtr length, out JsValue value);

		[DllImport(DllName.Universal, CharSet = CharSet.Ansi)]
		internal static extern JsErrorCode JsCopyString(JsValue value, byte[] buffer, UIntPtr bufferSize,
			out UIntPtr length);

		[DllImport(DllName.Universal, CharSet = CharSet.Unicode)]
		internal static extern JsErrorCode JsCopyStringUtf16(JsValue value, int start, int length,
			char[] buffer, out UIntPtr written);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsParse(JsValue script, JsSourceContext sourceContext, JsValue sourceUrl,
			JsParseScriptAttributes parseAttributes, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsRun(JsValue script, JsSourceContext sourceContext, JsValue sourceUrl,
			JsParseScriptAttributes parseAttributes, out JsValue result);

		[DllImport(DllName.Universal, CharSet = CharSet.Ansi)]
		internal static extern JsErrorCode JsCreatePropertyId(string name, UIntPtr length,
			out JsPropertyId propertyId);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsCopyPropertyId(JsPropertyId propertyId, byte[] buffer,
			UIntPtr bufferSize, out UIntPtr length);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsSerialize(JsValue script, out JsValue buffer,
			JsParseScriptAttributes parseAttributes);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsParseSerialized(JsValue buffer,
			JsSerializedLoadScriptCallback scriptLoadCallback, JsSourceContext sourceContext,
			JsValue sourceUrl, out JsValue result);

		[DllImport(DllName.Universal)]
		internal static extern JsErrorCode JsRunSerialized(JsValue buffer,
			JsSerializedLoadScriptCallback scriptLoadCallback, JsSourceContext sourceContext,
			JsValue sourceUrl, out JsValue result);

		#endregion
	}
}