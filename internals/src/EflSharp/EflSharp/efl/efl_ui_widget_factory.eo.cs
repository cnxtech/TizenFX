#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { 
/// <summary>Efl Ui Factory that provides <see cref="Efl.Ui.Widget"/>.
/// This factory is designed to build <see cref="Efl.Ui.Widget"/> and optionally set their <see cref="Efl.Ui.Widget.Style"/> if it was connected with <see cref="Efl.Ui.IPropertyBind.PropertyBind"/> &quot;<c>style</c>&quot;.</summary>
[WidgetFactoryNativeInherit]
public class WidgetFactory : Efl.LoopConsumer, Efl.Eo.IWrapper,Efl.Ui.IFactory,Efl.Ui.IFactoryBind,Efl.Ui.IPropertyBind
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass {
        get {
            if (((object)this).GetType() == typeof (WidgetFactory))
                return Efl.Ui.WidgetFactoryNativeInherit.GetEflClassStatic();
            else
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
        }
    }
    [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
        efl_ui_widget_factory_class_get();
    ///<summary>Creates a new instance.</summary>
    ///<param name="parent">Parent instance.</param>
    ///<param name="itemClass">Define the class of the item returned by this factory. See <see cref="Efl.Ui.WidgetFactory.SetItemClass"/></param>
    public WidgetFactory(Efl.Object parent
            , Type itemClass = null) :
        base(efl_ui_widget_factory_class_get(), typeof(WidgetFactory), parent)
    {
        if (Efl.Eo.Globals.ParamHelperCheck(itemClass))
            SetItemClass(Efl.Eo.Globals.GetParamHelper(itemClass));
        FinishInstantiation();
    }
    ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    protected WidgetFactory(System.IntPtr raw) : base(raw)
    {
                RegisterEventProxies();
    }
    ///<summary>Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    protected WidgetFactory(IntPtr base_klass, System.Type managed_type, Efl.Object parent) : base(base_klass, managed_type, parent) {}
    ///<summary>Verifies if the given object is equal to this one.</summary>
    public override bool Equals(object obj)
    {
        var other = obj as Efl.Object;
        if (other == null)
            return false;
        return this.NativeHandle == other.NativeHandle;
    }
    ///<summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }
    ///<summary>Turns the native pointer into a string representation.</summary>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }
private static object CreatedEvtKey = new object();
    /// <summary>Event triggered when an item has been successfully created.</summary>
    public event EventHandler<Efl.Ui.IFactoryCreatedEvt_Args> CreatedEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_FACTORY_EVENT_CREATED";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_CreatedEvt_delegate)) {
                    eventHandlers.AddHandler(CreatedEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_FACTORY_EVENT_CREATED";
                if (RemoveNativeEventHandler(key, this.evt_CreatedEvt_delegate)) { 
                    eventHandlers.RemoveHandler(CreatedEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event CreatedEvt.</summary>
    public void On_CreatedEvt(Efl.Ui.IFactoryCreatedEvt_Args e)
    {
        EventHandler<Efl.Ui.IFactoryCreatedEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IFactoryCreatedEvt_Args>)eventHandlers[CreatedEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_CreatedEvt_delegate;
    private void on_CreatedEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IFactoryCreatedEvt_Args args = new Efl.Ui.IFactoryCreatedEvt_Args();
      args.arg =  evt.Info;;
        try {
            On_CreatedEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object PropertiesChangedEvtKey = new object();
    /// <summary>Event dispatched when a property on the object has changed due to an user interaction on the object that a model could be interested in.</summary>
    public event EventHandler<Efl.Ui.IPropertyBindPropertiesChangedEvt_Args> PropertiesChangedEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_PROPERTY_BIND_EVENT_PROPERTIES_CHANGED";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_PropertiesChangedEvt_delegate)) {
                    eventHandlers.AddHandler(PropertiesChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_PROPERTY_BIND_EVENT_PROPERTIES_CHANGED";
                if (RemoveNativeEventHandler(key, this.evt_PropertiesChangedEvt_delegate)) { 
                    eventHandlers.RemoveHandler(PropertiesChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event PropertiesChangedEvt.</summary>
    public void On_PropertiesChangedEvt(Efl.Ui.IPropertyBindPropertiesChangedEvt_Args e)
    {
        EventHandler<Efl.Ui.IPropertyBindPropertiesChangedEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IPropertyBindPropertiesChangedEvt_Args>)eventHandlers[PropertiesChangedEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_PropertiesChangedEvt_delegate;
    private void on_PropertiesChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IPropertyBindPropertiesChangedEvt_Args args = new Efl.Ui.IPropertyBindPropertiesChangedEvt_Args();
      args.arg =  evt.Info;;
        try {
            On_PropertiesChangedEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object PropertyBoundEvtKey = new object();
    /// <summary>Event dispatched when a property on the object is bound to a model. This is useful to not overgenerate event.</summary>
    public event EventHandler<Efl.Ui.IPropertyBindPropertyBoundEvt_Args> PropertyBoundEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_PROPERTY_BIND_EVENT_PROPERTY_BOUND";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_PropertyBoundEvt_delegate)) {
                    eventHandlers.AddHandler(PropertyBoundEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_PROPERTY_BIND_EVENT_PROPERTY_BOUND";
                if (RemoveNativeEventHandler(key, this.evt_PropertyBoundEvt_delegate)) { 
                    eventHandlers.RemoveHandler(PropertyBoundEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event PropertyBoundEvt.</summary>
    public void On_PropertyBoundEvt(Efl.Ui.IPropertyBindPropertyBoundEvt_Args e)
    {
        EventHandler<Efl.Ui.IPropertyBindPropertyBoundEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IPropertyBindPropertyBoundEvt_Args>)eventHandlers[PropertyBoundEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_PropertyBoundEvt_delegate;
    private void on_PropertyBoundEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IPropertyBindPropertyBoundEvt_Args args = new Efl.Ui.IPropertyBindPropertyBoundEvt_Args();
      args.arg = Eina.StringConversion.NativeUtf8ToManagedString(evt.Info);
        try {
            On_PropertyBoundEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

    ///<summary>Register the Eo event wrappers making the bridge to C# events. Internal usage only.</summary>
    protected override void RegisterEventProxies()
    {
        base.RegisterEventProxies();
        evt_CreatedEvt_delegate = new Efl.EventCb(on_CreatedEvt_NativeCallback);
        evt_PropertiesChangedEvt_delegate = new Efl.EventCb(on_PropertiesChangedEvt_NativeCallback);
        evt_PropertyBoundEvt_delegate = new Efl.EventCb(on_PropertyBoundEvt_NativeCallback);
    }
    /// <summary>Define the class of the item returned by this factory.</summary>
    /// <returns>The class identifier to create item from.</returns>
    virtual public Type GetItemClass() {
         var _ret_var = Efl.Ui.WidgetFactoryNativeInherit.efl_ui_widget_factory_item_class_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Define the class of the item returned by this factory.</summary>
    /// <param name="klass">The class identifier to create item from.</param>
    /// <returns></returns>
    virtual public void SetItemClass( Type klass) {
                                 Efl.Ui.WidgetFactoryNativeInherit.efl_ui_widget_factory_item_class_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), klass);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Create a UI object from the necessary properties in the specified model.</summary>
    /// <param name="model">Efl model</param>
    /// <param name="parent">Efl canvas</param>
    /// <returns>Created UI object</returns>
    virtual public  Eina.Future Create( Efl.IModel model,  Efl.Gfx.IEntity parent) {
                                                         var _ret_var = Efl.Ui.IFactoryNativeInherit.efl_ui_factory_create_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), model,  parent);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Release a UI object and disconnect from models.</summary>
    /// <param name="ui_view">Efl canvas</param>
    /// <returns></returns>
    virtual public void Release( Efl.Gfx.IEntity ui_view) {
                                 Efl.Ui.IFactoryNativeInherit.efl_ui_factory_release_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), ui_view);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>bind the factory with the given key string. when the data is ready or changed, factory create the object and bind the data to the key action and process promised work. Note: the input <see cref="Efl.Ui.IFactory"/> need to be <see cref="Efl.Ui.IPropertyBind.PropertyBind"/> at least once.</summary>
    /// <param name="key">Key string for bind model property data</param>
    /// <param name="factory"><see cref="Efl.Ui.IFactory"/> for create and bind model property data</param>
    /// <returns></returns>
    virtual public void FactoryBind( System.String key,  Efl.Ui.IFactory factory) {
                                                         Efl.Ui.IFactoryBindNativeInherit.efl_ui_factory_bind_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), key,  factory);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>bind property data with the given key string. when the data is ready or changed, bind the data to the key action and process promised work.</summary>
    /// <param name="key">key string for bind model property data</param>
    /// <param name="property">Model property name</param>
    /// <returns>0 when it succeed, an error code otherwise.</returns>
    virtual public Eina.Error PropertyBind( System.String key,  System.String property) {
                                                         var _ret_var = Efl.Ui.IPropertyBindNativeInherit.efl_ui_property_bind_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), key,  property);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    public System.Threading.Tasks.Task<Eina.Value> CreateAsync( Efl.IModel model, Efl.Gfx.IEntity parent, System.Threading.CancellationToken token=default(System.Threading.CancellationToken))
    {
        Eina.Future future = Create(  model,  parent);
        return Efl.Eo.Globals.WrapAsync(future, token);
    }
    /// <summary>Define the class of the item returned by this factory.</summary>
/// <value>The class identifier to create item from.</value>
    public Type ItemClass {
        get { return GetItemClass(); }
        set { SetItemClass( value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.WidgetFactory.efl_ui_widget_factory_class_get();
    }
}
public class WidgetFactoryNativeInherit : Efl.LoopConsumerNativeInherit{
    public new  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
    public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
    {
        var descs = new System.Collections.Generic.List<Efl_Op_Description>();
        var methods = Efl.Eo.Globals.GetUserMethods(type);
        if (efl_ui_widget_factory_item_class_get_static_delegate == null)
            efl_ui_widget_factory_item_class_get_static_delegate = new efl_ui_widget_factory_item_class_get_delegate(item_class_get);
        if (methods.FirstOrDefault(m => m.Name == "GetItemClass") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_widget_factory_item_class_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_widget_factory_item_class_get_static_delegate)});
        if (efl_ui_widget_factory_item_class_set_static_delegate == null)
            efl_ui_widget_factory_item_class_set_static_delegate = new efl_ui_widget_factory_item_class_set_delegate(item_class_set);
        if (methods.FirstOrDefault(m => m.Name == "SetItemClass") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_widget_factory_item_class_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_widget_factory_item_class_set_static_delegate)});
        if (efl_ui_factory_create_static_delegate == null)
            efl_ui_factory_create_static_delegate = new efl_ui_factory_create_delegate(create);
        if (methods.FirstOrDefault(m => m.Name == "Create") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_factory_create"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_factory_create_static_delegate)});
        if (efl_ui_factory_release_static_delegate == null)
            efl_ui_factory_release_static_delegate = new efl_ui_factory_release_delegate(release);
        if (methods.FirstOrDefault(m => m.Name == "Release") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_factory_release"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_factory_release_static_delegate)});
        if (efl_ui_factory_bind_static_delegate == null)
            efl_ui_factory_bind_static_delegate = new efl_ui_factory_bind_delegate(factory_bind);
        if (methods.FirstOrDefault(m => m.Name == "FactoryBind") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_factory_bind"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_factory_bind_static_delegate)});
        if (efl_ui_property_bind_static_delegate == null)
            efl_ui_property_bind_static_delegate = new efl_ui_property_bind_delegate(property_bind);
        if (methods.FirstOrDefault(m => m.Name == "PropertyBind") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_property_bind"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_property_bind_static_delegate)});
        descs.AddRange(base.GetEoOps(type));
        return descs;
    }
    public override IntPtr GetEflClass()
    {
        return Efl.Ui.WidgetFactory.efl_ui_widget_factory_class_get();
    }
    public static new  IntPtr GetEflClassStatic()
    {
        return Efl.Ui.WidgetFactory.efl_ui_widget_factory_class_get();
    }


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEflClass))] private delegate Type efl_ui_widget_factory_item_class_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEflClass))] public delegate Type efl_ui_widget_factory_item_class_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_widget_factory_item_class_get_api_delegate> efl_ui_widget_factory_item_class_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_widget_factory_item_class_get_api_delegate>(_Module, "efl_ui_widget_factory_item_class_get");
     private static Type item_class_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_widget_factory_item_class_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        Type _ret_var = default(Type);
            try {
                _ret_var = ((WidgetFactory)wrapper).GetItemClass();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_ui_widget_factory_item_class_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_widget_factory_item_class_get_delegate efl_ui_widget_factory_item_class_get_static_delegate;


     private delegate void efl_ui_widget_factory_item_class_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEflClass))]  Type klass);


     public delegate void efl_ui_widget_factory_item_class_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEflClass))]  Type klass);
     public static Efl.Eo.FunctionWrapper<efl_ui_widget_factory_item_class_set_api_delegate> efl_ui_widget_factory_item_class_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_widget_factory_item_class_set_api_delegate>(_Module, "efl_ui_widget_factory_item_class_set");
     private static void item_class_set(System.IntPtr obj, System.IntPtr pd,  Type klass)
    {
        Eina.Log.Debug("function efl_ui_widget_factory_item_class_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((WidgetFactory)wrapper).SetItemClass( klass);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_ui_widget_factory_item_class_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  klass);
        }
    }
    private static efl_ui_widget_factory_item_class_set_delegate efl_ui_widget_factory_item_class_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.FutureMarshaler))] private delegate  Eina.Future efl_ui_factory_create_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.IModelConcrete, Efl.Eo.NonOwnTag>))]  Efl.IModel model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.IEntity parent);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.FutureMarshaler))] public delegate  Eina.Future efl_ui_factory_create_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.IModelConcrete, Efl.Eo.NonOwnTag>))]  Efl.IModel model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.IEntity parent);
     public static Efl.Eo.FunctionWrapper<efl_ui_factory_create_api_delegate> efl_ui_factory_create_ptr = new Efl.Eo.FunctionWrapper<efl_ui_factory_create_api_delegate>(_Module, "efl_ui_factory_create");
     private static  Eina.Future create(System.IntPtr obj, System.IntPtr pd,  Efl.IModel model,  Efl.Gfx.IEntity parent)
    {
        Eina.Log.Debug("function efl_ui_factory_create was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                                         Eina.Future _ret_var = default( Eina.Future);
            try {
                _ret_var = ((WidgetFactory)wrapper).Create( model,  parent);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                        return _ret_var;
        } else {
            return efl_ui_factory_create_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  model,  parent);
        }
    }
    private static efl_ui_factory_create_delegate efl_ui_factory_create_static_delegate;


     private delegate void efl_ui_factory_release_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.IEntity ui_view);


     public delegate void efl_ui_factory_release_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.IEntity ui_view);
     public static Efl.Eo.FunctionWrapper<efl_ui_factory_release_api_delegate> efl_ui_factory_release_ptr = new Efl.Eo.FunctionWrapper<efl_ui_factory_release_api_delegate>(_Module, "efl_ui_factory_release");
     private static void release(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.IEntity ui_view)
    {
        Eina.Log.Debug("function efl_ui_factory_release was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((WidgetFactory)wrapper).Release( ui_view);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_ui_factory_release_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  ui_view);
        }
    }
    private static efl_ui_factory_release_delegate efl_ui_factory_release_static_delegate;


     private delegate void efl_ui_factory_bind_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.IFactoryConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.IFactory factory);


     public delegate void efl_ui_factory_bind_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.IFactoryConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.IFactory factory);
     public static Efl.Eo.FunctionWrapper<efl_ui_factory_bind_api_delegate> efl_ui_factory_bind_ptr = new Efl.Eo.FunctionWrapper<efl_ui_factory_bind_api_delegate>(_Module, "efl_ui_factory_bind");
     private static void factory_bind(System.IntPtr obj, System.IntPtr pd,  System.String key,  Efl.Ui.IFactory factory)
    {
        Eina.Log.Debug("function efl_ui_factory_bind was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                                        
            try {
                ((WidgetFactory)wrapper).FactoryBind( key,  factory);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                                } else {
            efl_ui_factory_bind_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  key,  factory);
        }
    }
    private static efl_ui_factory_bind_delegate efl_ui_factory_bind_static_delegate;


     private delegate Eina.Error efl_ui_property_bind_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String key,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String property);


     public delegate Eina.Error efl_ui_property_bind_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String key,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String property);
     public static Efl.Eo.FunctionWrapper<efl_ui_property_bind_api_delegate> efl_ui_property_bind_ptr = new Efl.Eo.FunctionWrapper<efl_ui_property_bind_api_delegate>(_Module, "efl_ui_property_bind");
     private static Eina.Error property_bind(System.IntPtr obj, System.IntPtr pd,  System.String key,  System.String property)
    {
        Eina.Log.Debug("function efl_ui_property_bind was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                                        Eina.Error _ret_var = default(Eina.Error);
            try {
                _ret_var = ((WidgetFactory)wrapper).PropertyBind( key,  property);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                        return _ret_var;
        } else {
            return efl_ui_property_bind_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  key,  property);
        }
    }
    private static efl_ui_property_bind_delegate efl_ui_property_bind_static_delegate;
}
} } 
