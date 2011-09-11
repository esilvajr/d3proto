// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=8fd7408b07f8d2cd.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace D3.Client {
  
  public static partial class Settings {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_D3_Client_ToonSettings__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::D3.Client.ToonSettings, global::D3.Client.ToonSettings.Builder> internal__static_D3_Client_ToonSettings__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_D3_Client_GameAccountSettings__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::D3.Client.GameAccountSettings, global::D3.Client.GameAccountSettings.Builder> internal__static_D3_Client_GameAccountSettings__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Settings() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "Cg5TZXR0aW5ncy5wcm90bxIJRDMuQ2xpZW50IiMKDFRvb25TZXR0aW5ncxIT" + 
          "Cgh1aV9mbGFncxgBIAEoDToBMCJOChNHYW1lQWNjb3VudFNldHRpbmdzEhgK" + 
          "DXVzZV9sYXN0X2hlcm8YASABKAU6ATASHQoSc2hvd19vZmZsaW5lX3RvYXN0" + 
          "GAIgASgFOgEw");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_D3_Client_ToonSettings__Descriptor = Descriptor.MessageTypes[0];
        internal__static_D3_Client_ToonSettings__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::D3.Client.ToonSettings, global::D3.Client.ToonSettings.Builder>(internal__static_D3_Client_ToonSettings__Descriptor,
                new string[] { "UiFlags", });
        internal__static_D3_Client_GameAccountSettings__Descriptor = Descriptor.MessageTypes[1];
        internal__static_D3_Client_GameAccountSettings__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::D3.Client.GameAccountSettings, global::D3.Client.GameAccountSettings.Builder>(internal__static_D3_Client_GameAccountSettings__Descriptor,
                new string[] { "UseLastHero", "ShowOfflineToast", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  public sealed partial class ToonSettings : pb::GeneratedMessage<ToonSettings, ToonSettings.Builder> {
    private static readonly ToonSettings defaultInstance = new Builder().BuildPartial();
    public static ToonSettings DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override ToonSettings DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override ToonSettings ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::D3.Client.Settings.internal__static_D3_Client_ToonSettings__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<ToonSettings, ToonSettings.Builder> InternalFieldAccessors {
      get { return global::D3.Client.Settings.internal__static_D3_Client_ToonSettings__FieldAccessorTable; }
    }
    
    public const int UiFlagsFieldNumber = 1;
    private bool hasUiFlags;
    private uint uiFlags_ = 0;
    public bool HasUiFlags {
      get { return hasUiFlags; }
    }
    public uint UiFlags {
      get { return uiFlags_; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasUiFlags) {
        output.WriteUInt32(1, UiFlags);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasUiFlags) {
          size += pb::CodedOutputStream.ComputeUInt32Size(1, UiFlags);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static ToonSettings ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ToonSettings ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ToonSettings ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ToonSettings ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ToonSettings ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ToonSettings ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ToonSettings ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ToonSettings ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ToonSettings ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ToonSettings ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ToonSettings prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<ToonSettings, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      ToonSettings result = new ToonSettings();
      
      protected override ToonSettings MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new ToonSettings();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::D3.Client.ToonSettings.Descriptor; }
      }
      
      public override ToonSettings DefaultInstanceForType {
        get { return global::D3.Client.ToonSettings.DefaultInstance; }
      }
      
      public override ToonSettings BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        ToonSettings returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is ToonSettings) {
          return MergeFrom((ToonSettings) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(ToonSettings other) {
        if (other == global::D3.Client.ToonSettings.DefaultInstance) return this;
        if (other.HasUiFlags) {
          UiFlags = other.UiFlags;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 8: {
              UiFlags = input.ReadUInt32();
              break;
            }
          }
        }
      }
      
      
      public bool HasUiFlags {
        get { return result.HasUiFlags; }
      }
      public uint UiFlags {
        get { return result.UiFlags; }
        set { SetUiFlags(value); }
      }
      public Builder SetUiFlags(uint value) {
        result.hasUiFlags = true;
        result.uiFlags_ = value;
        return this;
      }
      public Builder ClearUiFlags() {
        result.hasUiFlags = false;
        result.uiFlags_ = 0;
        return this;
      }
    }
    static ToonSettings() {
      object.ReferenceEquals(global::D3.Client.Settings.Descriptor, null);
    }
  }
  
  public sealed partial class GameAccountSettings : pb::GeneratedMessage<GameAccountSettings, GameAccountSettings.Builder> {
    private static readonly GameAccountSettings defaultInstance = new Builder().BuildPartial();
    public static GameAccountSettings DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override GameAccountSettings DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override GameAccountSettings ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::D3.Client.Settings.internal__static_D3_Client_GameAccountSettings__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<GameAccountSettings, GameAccountSettings.Builder> InternalFieldAccessors {
      get { return global::D3.Client.Settings.internal__static_D3_Client_GameAccountSettings__FieldAccessorTable; }
    }
    
    public const int UseLastHeroFieldNumber = 1;
    private bool hasUseLastHero;
    private int useLastHero_ = 0;
    public bool HasUseLastHero {
      get { return hasUseLastHero; }
    }
    public int UseLastHero {
      get { return useLastHero_; }
    }
    
    public const int ShowOfflineToastFieldNumber = 2;
    private bool hasShowOfflineToast;
    private int showOfflineToast_ = 0;
    public bool HasShowOfflineToast {
      get { return hasShowOfflineToast; }
    }
    public int ShowOfflineToast {
      get { return showOfflineToast_; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasUseLastHero) {
        output.WriteInt32(1, UseLastHero);
      }
      if (HasShowOfflineToast) {
        output.WriteInt32(2, ShowOfflineToast);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasUseLastHero) {
          size += pb::CodedOutputStream.ComputeInt32Size(1, UseLastHero);
        }
        if (HasShowOfflineToast) {
          size += pb::CodedOutputStream.ComputeInt32Size(2, ShowOfflineToast);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static GameAccountSettings ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static GameAccountSettings ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static GameAccountSettings ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static GameAccountSettings ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static GameAccountSettings ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static GameAccountSettings ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static GameAccountSettings ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static GameAccountSettings ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static GameAccountSettings ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static GameAccountSettings ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(GameAccountSettings prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<GameAccountSettings, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      GameAccountSettings result = new GameAccountSettings();
      
      protected override GameAccountSettings MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new GameAccountSettings();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::D3.Client.GameAccountSettings.Descriptor; }
      }
      
      public override GameAccountSettings DefaultInstanceForType {
        get { return global::D3.Client.GameAccountSettings.DefaultInstance; }
      }
      
      public override GameAccountSettings BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        GameAccountSettings returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is GameAccountSettings) {
          return MergeFrom((GameAccountSettings) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(GameAccountSettings other) {
        if (other == global::D3.Client.GameAccountSettings.DefaultInstance) return this;
        if (other.HasUseLastHero) {
          UseLastHero = other.UseLastHero;
        }
        if (other.HasShowOfflineToast) {
          ShowOfflineToast = other.ShowOfflineToast;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 8: {
              UseLastHero = input.ReadInt32();
              break;
            }
            case 16: {
              ShowOfflineToast = input.ReadInt32();
              break;
            }
          }
        }
      }
      
      
      public bool HasUseLastHero {
        get { return result.HasUseLastHero; }
      }
      public int UseLastHero {
        get { return result.UseLastHero; }
        set { SetUseLastHero(value); }
      }
      public Builder SetUseLastHero(int value) {
        result.hasUseLastHero = true;
        result.useLastHero_ = value;
        return this;
      }
      public Builder ClearUseLastHero() {
        result.hasUseLastHero = false;
        result.useLastHero_ = 0;
        return this;
      }
      
      public bool HasShowOfflineToast {
        get { return result.HasShowOfflineToast; }
      }
      public int ShowOfflineToast {
        get { return result.ShowOfflineToast; }
        set { SetShowOfflineToast(value); }
      }
      public Builder SetShowOfflineToast(int value) {
        result.hasShowOfflineToast = true;
        result.showOfflineToast_ = value;
        return this;
      }
      public Builder ClearShowOfflineToast() {
        result.hasShowOfflineToast = false;
        result.showOfflineToast_ = 0;
        return this;
      }
    }
    static GameAccountSettings() {
      object.ReferenceEquals(global::D3.Client.Settings.Descriptor, null);
    }
  }
  
  #endregion
  
}
