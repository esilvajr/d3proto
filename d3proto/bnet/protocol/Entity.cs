// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=8fd7408b07f8d2cd.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol {
  
  public static partial class Entity {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_EntityId__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.EntityId, global::bnet.protocol.EntityId.Builder> internal__static_bnet_protocol_EntityId__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_Identity__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.Identity, global::bnet.protocol.Identity.Builder> internal__static_bnet_protocol_Identity__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Entity() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChlsaWIvcHJvdG9jb2wvZW50aXR5LnByb3RvEg1ibmV0LnByb3RvY29sIiUK" + 
          "CEVudGl0eUlkEgwKBGhpZ2gYASACKAYSCwoDbG93GAIgAigGIpMBCghJZGVu" + 
          "dGl0eRIrCgphY2NvdW50X2lkGAEgASgLMhcuYm5ldC5wcm90b2NvbC5FbnRp" + 
          "dHlJZBIwCg9nYW1lX2FjY291bnRfaWQYAiABKAsyFy5ibmV0LnByb3RvY29s" + 
          "LkVudGl0eUlkEigKB3Rvb25faWQYAyABKAsyFy5ibmV0LnByb3RvY29sLkVu" + 
          "dGl0eUlk");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bnet_protocol_EntityId__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bnet_protocol_EntityId__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.EntityId, global::bnet.protocol.EntityId.Builder>(internal__static_bnet_protocol_EntityId__Descriptor,
                new string[] { "High", "Low", });
        internal__static_bnet_protocol_Identity__Descriptor = Descriptor.MessageTypes[1];
        internal__static_bnet_protocol_Identity__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.Identity, global::bnet.protocol.Identity.Builder>(internal__static_bnet_protocol_Identity__Descriptor,
                new string[] { "AccountId", "GameAccountId", "ToonId", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  public sealed partial class EntityId : pb::GeneratedMessage<EntityId, EntityId.Builder> {
    private static readonly EntityId defaultInstance = new Builder().BuildPartial();
    public static EntityId DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override EntityId DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override EntityId ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.Entity.internal__static_bnet_protocol_EntityId__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<EntityId, EntityId.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.Entity.internal__static_bnet_protocol_EntityId__FieldAccessorTable; }
    }
    
    public const int HighFieldNumber = 1;
    private bool hasHigh;
    private ulong high_ = 0;
    public bool HasHigh {
      get { return hasHigh; }
    }
    public ulong High {
      get { return high_; }
    }
    
    public const int LowFieldNumber = 2;
    private bool hasLow;
    private ulong low_ = 0;
    public bool HasLow {
      get { return hasLow; }
    }
    public ulong Low {
      get { return low_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasHigh) return false;
        if (!hasLow) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasHigh) {
        output.WriteFixed64(1, High);
      }
      if (HasLow) {
        output.WriteFixed64(2, Low);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasHigh) {
          size += pb::CodedOutputStream.ComputeFixed64Size(1, High);
        }
        if (HasLow) {
          size += pb::CodedOutputStream.ComputeFixed64Size(2, Low);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static EntityId ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static EntityId ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static EntityId ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static EntityId ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static EntityId ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static EntityId ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static EntityId ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static EntityId ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static EntityId ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static EntityId ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(EntityId prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<EntityId, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      EntityId result = new EntityId();
      
      protected override EntityId MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new EntityId();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.EntityId.Descriptor; }
      }
      
      public override EntityId DefaultInstanceForType {
        get { return global::bnet.protocol.EntityId.DefaultInstance; }
      }
      
      public override EntityId BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        EntityId returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is EntityId) {
          return MergeFrom((EntityId) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(EntityId other) {
        if (other == global::bnet.protocol.EntityId.DefaultInstance) return this;
        if (other.HasHigh) {
          High = other.High;
        }
        if (other.HasLow) {
          Low = other.Low;
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
            case 9: {
              High = input.ReadFixed64();
              break;
            }
            case 17: {
              Low = input.ReadFixed64();
              break;
            }
          }
        }
      }
      
      
      public bool HasHigh {
        get { return result.HasHigh; }
      }
      public ulong High {
        get { return result.High; }
        set { SetHigh(value); }
      }
      public Builder SetHigh(ulong value) {
        result.hasHigh = true;
        result.high_ = value;
        return this;
      }
      public Builder ClearHigh() {
        result.hasHigh = false;
        result.high_ = 0;
        return this;
      }
      
      public bool HasLow {
        get { return result.HasLow; }
      }
      public ulong Low {
        get { return result.Low; }
        set { SetLow(value); }
      }
      public Builder SetLow(ulong value) {
        result.hasLow = true;
        result.low_ = value;
        return this;
      }
      public Builder ClearLow() {
        result.hasLow = false;
        result.low_ = 0;
        return this;
      }
    }
    static EntityId() {
      object.ReferenceEquals(global::bnet.protocol.Entity.Descriptor, null);
    }
  }
  
  public sealed partial class Identity : pb::GeneratedMessage<Identity, Identity.Builder> {
    private static readonly Identity defaultInstance = new Builder().BuildPartial();
    public static Identity DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Identity DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Identity ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.Entity.internal__static_bnet_protocol_Identity__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Identity, Identity.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.Entity.internal__static_bnet_protocol_Identity__FieldAccessorTable; }
    }
    
    public const int AccountIdFieldNumber = 1;
    private bool hasAccountId;
    private global::bnet.protocol.EntityId accountId_ = global::bnet.protocol.EntityId.DefaultInstance;
    public bool HasAccountId {
      get { return hasAccountId; }
    }
    public global::bnet.protocol.EntityId AccountId {
      get { return accountId_; }
    }
    
    public const int GameAccountIdFieldNumber = 2;
    private bool hasGameAccountId;
    private global::bnet.protocol.EntityId gameAccountId_ = global::bnet.protocol.EntityId.DefaultInstance;
    public bool HasGameAccountId {
      get { return hasGameAccountId; }
    }
    public global::bnet.protocol.EntityId GameAccountId {
      get { return gameAccountId_; }
    }
    
    public const int ToonIdFieldNumber = 3;
    private bool hasToonId;
    private global::bnet.protocol.EntityId toonId_ = global::bnet.protocol.EntityId.DefaultInstance;
    public bool HasToonId {
      get { return hasToonId; }
    }
    public global::bnet.protocol.EntityId ToonId {
      get { return toonId_; }
    }
    
    public override bool IsInitialized {
      get {
        if (HasAccountId) {
          if (!AccountId.IsInitialized) return false;
        }
        if (HasGameAccountId) {
          if (!GameAccountId.IsInitialized) return false;
        }
        if (HasToonId) {
          if (!ToonId.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasAccountId) {
        output.WriteMessage(1, AccountId);
      }
      if (HasGameAccountId) {
        output.WriteMessage(2, GameAccountId);
      }
      if (HasToonId) {
        output.WriteMessage(3, ToonId);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasAccountId) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, AccountId);
        }
        if (HasGameAccountId) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, GameAccountId);
        }
        if (HasToonId) {
          size += pb::CodedOutputStream.ComputeMessageSize(3, ToonId);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Identity ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Identity ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Identity ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Identity ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Identity ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Identity ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Identity ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Identity ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Identity ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Identity ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Identity prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<Identity, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Identity result = new Identity();
      
      protected override Identity MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Identity();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.Identity.Descriptor; }
      }
      
      public override Identity DefaultInstanceForType {
        get { return global::bnet.protocol.Identity.DefaultInstance; }
      }
      
      public override Identity BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        Identity returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Identity) {
          return MergeFrom((Identity) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Identity other) {
        if (other == global::bnet.protocol.Identity.DefaultInstance) return this;
        if (other.HasAccountId) {
          MergeAccountId(other.AccountId);
        }
        if (other.HasGameAccountId) {
          MergeGameAccountId(other.GameAccountId);
        }
        if (other.HasToonId) {
          MergeToonId(other.ToonId);
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
            case 10: {
              global::bnet.protocol.EntityId.Builder subBuilder = global::bnet.protocol.EntityId.CreateBuilder();
              if (HasAccountId) {
                subBuilder.MergeFrom(AccountId);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              AccountId = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              global::bnet.protocol.EntityId.Builder subBuilder = global::bnet.protocol.EntityId.CreateBuilder();
              if (HasGameAccountId) {
                subBuilder.MergeFrom(GameAccountId);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              GameAccountId = subBuilder.BuildPartial();
              break;
            }
            case 26: {
              global::bnet.protocol.EntityId.Builder subBuilder = global::bnet.protocol.EntityId.CreateBuilder();
              if (HasToonId) {
                subBuilder.MergeFrom(ToonId);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              ToonId = subBuilder.BuildPartial();
              break;
            }
          }
        }
      }
      
      
      public bool HasAccountId {
       get { return result.HasAccountId; }
      }
      public global::bnet.protocol.EntityId AccountId {
        get { return result.AccountId; }
        set { SetAccountId(value); }
      }
      public Builder SetAccountId(global::bnet.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasAccountId = true;
        result.accountId_ = value;
        return this;
      }
      public Builder SetAccountId(global::bnet.protocol.EntityId.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasAccountId = true;
        result.accountId_ = builderForValue.Build();
        return this;
      }
      public Builder MergeAccountId(global::bnet.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.HasAccountId &&
            result.accountId_ != global::bnet.protocol.EntityId.DefaultInstance) {
            result.accountId_ = global::bnet.protocol.EntityId.CreateBuilder(result.accountId_).MergeFrom(value).BuildPartial();
        } else {
          result.accountId_ = value;
        }
        result.hasAccountId = true;
        return this;
      }
      public Builder ClearAccountId() {
        result.hasAccountId = false;
        result.accountId_ = global::bnet.protocol.EntityId.DefaultInstance;
        return this;
      }
      
      public bool HasGameAccountId {
       get { return result.HasGameAccountId; }
      }
      public global::bnet.protocol.EntityId GameAccountId {
        get { return result.GameAccountId; }
        set { SetGameAccountId(value); }
      }
      public Builder SetGameAccountId(global::bnet.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasGameAccountId = true;
        result.gameAccountId_ = value;
        return this;
      }
      public Builder SetGameAccountId(global::bnet.protocol.EntityId.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasGameAccountId = true;
        result.gameAccountId_ = builderForValue.Build();
        return this;
      }
      public Builder MergeGameAccountId(global::bnet.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.HasGameAccountId &&
            result.gameAccountId_ != global::bnet.protocol.EntityId.DefaultInstance) {
            result.gameAccountId_ = global::bnet.protocol.EntityId.CreateBuilder(result.gameAccountId_).MergeFrom(value).BuildPartial();
        } else {
          result.gameAccountId_ = value;
        }
        result.hasGameAccountId = true;
        return this;
      }
      public Builder ClearGameAccountId() {
        result.hasGameAccountId = false;
        result.gameAccountId_ = global::bnet.protocol.EntityId.DefaultInstance;
        return this;
      }
      
      public bool HasToonId {
       get { return result.HasToonId; }
      }
      public global::bnet.protocol.EntityId ToonId {
        get { return result.ToonId; }
        set { SetToonId(value); }
      }
      public Builder SetToonId(global::bnet.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasToonId = true;
        result.toonId_ = value;
        return this;
      }
      public Builder SetToonId(global::bnet.protocol.EntityId.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasToonId = true;
        result.toonId_ = builderForValue.Build();
        return this;
      }
      public Builder MergeToonId(global::bnet.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.HasToonId &&
            result.toonId_ != global::bnet.protocol.EntityId.DefaultInstance) {
            result.toonId_ = global::bnet.protocol.EntityId.CreateBuilder(result.toonId_).MergeFrom(value).BuildPartial();
        } else {
          result.toonId_ = value;
        }
        result.hasToonId = true;
        return this;
      }
      public Builder ClearToonId() {
        result.hasToonId = false;
        result.toonId_ = global::bnet.protocol.EntityId.DefaultInstance;
        return this;
      }
    }
    static Identity() {
      object.ReferenceEquals(global::bnet.protocol.Entity.Descriptor, null);
    }
  }
  
  #endregion
  
}
