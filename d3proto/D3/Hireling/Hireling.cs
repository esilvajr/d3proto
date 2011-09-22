// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace D3.Hireling {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public static partial class Hireling {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_D3_Hireling_Info__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::D3.Hireling.Info, global::D3.Hireling.Info.Builder> internal__static_D3_Hireling_Info__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_D3_Hireling_SavedData__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::D3.Hireling.SavedData, global::D3.Hireling.SavedData.Builder> internal__static_D3_Hireling_SavedData__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Hireling() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "Cg5IaXJlbGluZy5wcm90bxILRDMuSGlyZWxpbmcikgEKBEluZm8SGQoOaGly" + 
          "ZWxpbmdfY2xhc3MYASACKBE6ATASFQoJZ2JpZF9uYW1lGAIgAigPOgItMRIN" + 
          "CgVsZXZlbBgDIAIoERIhChlhdHRyaWJ1dGVfZXhwZXJpZW5jZV9uZXh0GAQg" + 
          "AigNEhgKEHBvd2VyX2tleV9wYXJhbXMYCyADKBESDAoEZGVhZBgMIAIoCCJ2" + 
          "CglTYXZlZERhdGESJAoJaGlyZWxpbmdzGAEgAygLMhEuRDMuSGlyZWxpbmcu" + 
          "SW5mbxIaCg9hY3RpdmVfaGlyZWxpbmcYAiACKA06ATASJwocYXZhaWxhYmxl" + 
          "X2hpcmVsaW5nc19iaXRmaWVsZBgDIAIoDToBMA==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_D3_Hireling_Info__Descriptor = Descriptor.MessageTypes[0];
        internal__static_D3_Hireling_Info__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::D3.Hireling.Info, global::D3.Hireling.Info.Builder>(internal__static_D3_Hireling_Info__Descriptor,
                new string[] { "HirelingClass", "GbidName", "Level", "AttributeExperienceNext", "PowerKeyParams", "Dead", });
        internal__static_D3_Hireling_SavedData__Descriptor = Descriptor.MessageTypes[1];
        internal__static_D3_Hireling_SavedData__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::D3.Hireling.SavedData, global::D3.Hireling.SavedData.Builder>(internal__static_D3_Hireling_SavedData__Descriptor,
                new string[] { "Hirelings", "ActiveHireling", "AvailableHirelingsBitfield", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class Info : pb::GeneratedMessage<Info, Info.Builder> {
    private static readonly Info defaultInstance = new Builder().BuildPartial();
    private static readonly string[] _infoFieldNames = new string[] { "attribute_experience_next", "dead", "gbid_name", "hireling_class", "level", "power_key_params" };
    private static readonly uint[] _infoFieldTags = new uint[] { 32, 96, 21, 8, 24, 88 };
    public static Info DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Info DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Info ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::D3.Hireling.Hireling.internal__static_D3_Hireling_Info__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Info, Info.Builder> InternalFieldAccessors {
      get { return global::D3.Hireling.Hireling.internal__static_D3_Hireling_Info__FieldAccessorTable; }
    }
    
    public const int HirelingClassFieldNumber = 1;
    private bool hasHirelingClass;
    private int hirelingClass_;
    public bool HasHirelingClass {
      get { return hasHirelingClass; }
    }
    public int HirelingClass {
      get { return hirelingClass_; }
    }
    
    public const int GbidNameFieldNumber = 2;
    private bool hasGbidName;
    private int gbidName_ = -1;
    public bool HasGbidName {
      get { return hasGbidName; }
    }
    public int GbidName {
      get { return gbidName_; }
    }
    
    public const int LevelFieldNumber = 3;
    private bool hasLevel;
    private int level_;
    public bool HasLevel {
      get { return hasLevel; }
    }
    public int Level {
      get { return level_; }
    }
    
    public const int AttributeExperienceNextFieldNumber = 4;
    private bool hasAttributeExperienceNext;
    private uint attributeExperienceNext_;
    public bool HasAttributeExperienceNext {
      get { return hasAttributeExperienceNext; }
    }
    public uint AttributeExperienceNext {
      get { return attributeExperienceNext_; }
    }
    
    public const int PowerKeyParamsFieldNumber = 11;
    private pbc::PopsicleList<int> powerKeyParams_ = new pbc::PopsicleList<int>();
    public scg::IList<int> PowerKeyParamsList {
      get { return pbc::Lists.AsReadOnly(powerKeyParams_); }
    }
    public int PowerKeyParamsCount {
      get { return powerKeyParams_.Count; }
    }
    public int GetPowerKeyParams(int index) {
      return powerKeyParams_[index];
    }
    
    public const int DeadFieldNumber = 12;
    private bool hasDead;
    private bool dead_;
    public bool HasDead {
      get { return hasDead; }
    }
    public bool Dead {
      get { return dead_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasHirelingClass) return false;
        if (!hasGbidName) return false;
        if (!hasLevel) return false;
        if (!hasAttributeExperienceNext) return false;
        if (!hasDead) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _infoFieldNames;
      if (hasHirelingClass) {
        output.WriteSInt32(1, field_names[3], HirelingClass);
      }
      if (hasGbidName) {
        output.WriteSFixed32(2, field_names[2], GbidName);
      }
      if (hasLevel) {
        output.WriteSInt32(3, field_names[4], Level);
      }
      if (hasAttributeExperienceNext) {
        output.WriteUInt32(4, field_names[0], AttributeExperienceNext);
      }
      if (powerKeyParams_.Count > 0) {
        output.WriteSInt32Array(11, field_names[5], powerKeyParams_);
      }
      if (hasDead) {
        output.WriteBool(12, field_names[1], Dead);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasHirelingClass) {
          size += pb::CodedOutputStream.ComputeSInt32Size(1, HirelingClass);
        }
        if (hasGbidName) {
          size += pb::CodedOutputStream.ComputeSFixed32Size(2, GbidName);
        }
        if (hasLevel) {
          size += pb::CodedOutputStream.ComputeSInt32Size(3, Level);
        }
        if (hasAttributeExperienceNext) {
          size += pb::CodedOutputStream.ComputeUInt32Size(4, AttributeExperienceNext);
        }
        {
          int dataSize = 0;
          foreach (int element in PowerKeyParamsList) {
            dataSize += pb::CodedOutputStream.ComputeSInt32SizeNoTag(element);
          }
          size += dataSize;
          size += 1 * powerKeyParams_.Count;
        }
        if (hasDead) {
          size += pb::CodedOutputStream.ComputeBoolSize(12, Dead);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Info ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Info ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Info ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Info ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Info ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Info ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Info ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Info ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Info ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Info ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Info prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilder<Info, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Info result = new Info();
      
      protected override Info MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Info();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::D3.Hireling.Info.Descriptor; }
      }
      
      public override Info DefaultInstanceForType {
        get { return global::D3.Hireling.Info.DefaultInstance; }
      }
      
      public override Info BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        result.powerKeyParams_.MakeReadOnly();
        Info returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Info) {
          return MergeFrom((Info) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Info other) {
        if (other == global::D3.Hireling.Info.DefaultInstance) return this;
        if (other.HasHirelingClass) {
          HirelingClass = other.HirelingClass;
        }
        if (other.HasGbidName) {
          GbidName = other.GbidName;
        }
        if (other.HasLevel) {
          Level = other.Level;
        }
        if (other.HasAttributeExperienceNext) {
          AttributeExperienceNext = other.AttributeExperienceNext;
        }
        if (other.powerKeyParams_.Count != 0) {
          result.powerKeyParams_.Add(other.powerKeyParams_);
        }
        if (other.HasDead) {
          Dead = other.Dead;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_infoFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _infoFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
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
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasHirelingClass = input.ReadSInt32(ref result.hirelingClass_);
              break;
            }
            case 21: {
              result.hasGbidName = input.ReadSFixed32(ref result.gbidName_);
              break;
            }
            case 24: {
              result.hasLevel = input.ReadSInt32(ref result.level_);
              break;
            }
            case 32: {
              result.hasAttributeExperienceNext = input.ReadUInt32(ref result.attributeExperienceNext_);
              break;
            }
            case 90:
            case 88: {
              input.ReadSInt32Array(tag, field_name, result.powerKeyParams_);
              break;
            }
            case 96: {
              result.hasDead = input.ReadBool(ref result.dead_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasHirelingClass {
        get { return result.hasHirelingClass; }
      }
      public int HirelingClass {
        get { return result.HirelingClass; }
        set { SetHirelingClass(value); }
      }
      public Builder SetHirelingClass(int value) {
        result.hasHirelingClass = true;
        result.hirelingClass_ = value;
        return this;
      }
      public Builder ClearHirelingClass() {
        result.hasHirelingClass = false;
        result.hirelingClass_ = 0;
        return this;
      }
      
      public bool HasGbidName {
        get { return result.hasGbidName; }
      }
      public int GbidName {
        get { return result.GbidName; }
        set { SetGbidName(value); }
      }
      public Builder SetGbidName(int value) {
        result.hasGbidName = true;
        result.gbidName_ = value;
        return this;
      }
      public Builder ClearGbidName() {
        result.hasGbidName = false;
        result.gbidName_ = -1;
        return this;
      }
      
      public bool HasLevel {
        get { return result.hasLevel; }
      }
      public int Level {
        get { return result.Level; }
        set { SetLevel(value); }
      }
      public Builder SetLevel(int value) {
        result.hasLevel = true;
        result.level_ = value;
        return this;
      }
      public Builder ClearLevel() {
        result.hasLevel = false;
        result.level_ = 0;
        return this;
      }
      
      public bool HasAttributeExperienceNext {
        get { return result.hasAttributeExperienceNext; }
      }
      public uint AttributeExperienceNext {
        get { return result.AttributeExperienceNext; }
        set { SetAttributeExperienceNext(value); }
      }
      public Builder SetAttributeExperienceNext(uint value) {
        result.hasAttributeExperienceNext = true;
        result.attributeExperienceNext_ = value;
        return this;
      }
      public Builder ClearAttributeExperienceNext() {
        result.hasAttributeExperienceNext = false;
        result.attributeExperienceNext_ = 0;
        return this;
      }
      
      public pbc::IPopsicleList<int> PowerKeyParamsList {
        get { return result.powerKeyParams_; }
      }
      public int PowerKeyParamsCount {
        get { return result.PowerKeyParamsCount; }
      }
      public int GetPowerKeyParams(int index) {
        return result.GetPowerKeyParams(index);
      }
      public Builder SetPowerKeyParams(int index, int value) {
        result.powerKeyParams_[index] = value;
        return this;
      }
      public Builder AddPowerKeyParams(int value) {
        result.powerKeyParams_.Add(value);
        return this;
      }
      public Builder AddRangePowerKeyParams(scg::IEnumerable<int> values) {
        result.powerKeyParams_.Add(values);
        return this;
      }
      public Builder ClearPowerKeyParams() {
        result.powerKeyParams_.Clear();
        return this;
      }
      
      public bool HasDead {
        get { return result.hasDead; }
      }
      public bool Dead {
        get { return result.Dead; }
        set { SetDead(value); }
      }
      public Builder SetDead(bool value) {
        result.hasDead = true;
        result.dead_ = value;
        return this;
      }
      public Builder ClearDead() {
        result.hasDead = false;
        result.dead_ = false;
        return this;
      }
    }
    static Info() {
      object.ReferenceEquals(global::D3.Hireling.Hireling.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class SavedData : pb::GeneratedMessage<SavedData, SavedData.Builder> {
    private static readonly SavedData defaultInstance = new Builder().BuildPartial();
    private static readonly string[] _savedDataFieldNames = new string[] { "active_hireling", "available_hirelings_bitfield", "hirelings" };
    private static readonly uint[] _savedDataFieldTags = new uint[] { 16, 24, 10 };
    public static SavedData DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override SavedData DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override SavedData ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::D3.Hireling.Hireling.internal__static_D3_Hireling_SavedData__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<SavedData, SavedData.Builder> InternalFieldAccessors {
      get { return global::D3.Hireling.Hireling.internal__static_D3_Hireling_SavedData__FieldAccessorTable; }
    }
    
    public const int HirelingsFieldNumber = 1;
    private pbc::PopsicleList<global::D3.Hireling.Info> hirelings_ = new pbc::PopsicleList<global::D3.Hireling.Info>();
    public scg::IList<global::D3.Hireling.Info> HirelingsList {
      get { return hirelings_; }
    }
    public int HirelingsCount {
      get { return hirelings_.Count; }
    }
    public global::D3.Hireling.Info GetHirelings(int index) {
      return hirelings_[index];
    }
    
    public const int ActiveHirelingFieldNumber = 2;
    private bool hasActiveHireling;
    private uint activeHireling_;
    public bool HasActiveHireling {
      get { return hasActiveHireling; }
    }
    public uint ActiveHireling {
      get { return activeHireling_; }
    }
    
    public const int AvailableHirelingsBitfieldFieldNumber = 3;
    private bool hasAvailableHirelingsBitfield;
    private uint availableHirelingsBitfield_;
    public bool HasAvailableHirelingsBitfield {
      get { return hasAvailableHirelingsBitfield; }
    }
    public uint AvailableHirelingsBitfield {
      get { return availableHirelingsBitfield_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasActiveHireling) return false;
        if (!hasAvailableHirelingsBitfield) return false;
        foreach (global::D3.Hireling.Info element in HirelingsList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _savedDataFieldNames;
      if (hirelings_.Count > 0) {
        output.WriteMessageArray(1, field_names[2], hirelings_);
      }
      if (hasActiveHireling) {
        output.WriteUInt32(2, field_names[0], ActiveHireling);
      }
      if (hasAvailableHirelingsBitfield) {
        output.WriteUInt32(3, field_names[1], AvailableHirelingsBitfield);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        foreach (global::D3.Hireling.Info element in HirelingsList) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, element);
        }
        if (hasActiveHireling) {
          size += pb::CodedOutputStream.ComputeUInt32Size(2, ActiveHireling);
        }
        if (hasAvailableHirelingsBitfield) {
          size += pb::CodedOutputStream.ComputeUInt32Size(3, AvailableHirelingsBitfield);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static SavedData ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static SavedData ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static SavedData ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static SavedData ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static SavedData ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static SavedData ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static SavedData ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static SavedData ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static SavedData ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static SavedData ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(SavedData prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilder<SavedData, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      SavedData result = new SavedData();
      
      protected override SavedData MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new SavedData();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::D3.Hireling.SavedData.Descriptor; }
      }
      
      public override SavedData DefaultInstanceForType {
        get { return global::D3.Hireling.SavedData.DefaultInstance; }
      }
      
      public override SavedData BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        result.hirelings_.MakeReadOnly();
        SavedData returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is SavedData) {
          return MergeFrom((SavedData) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(SavedData other) {
        if (other == global::D3.Hireling.SavedData.DefaultInstance) return this;
        if (other.hirelings_.Count != 0) {
          result.hirelings_.Add(other.hirelings_);
        }
        if (other.HasActiveHireling) {
          ActiveHireling = other.ActiveHireling;
        }
        if (other.HasAvailableHirelingsBitfield) {
          AvailableHirelingsBitfield = other.AvailableHirelingsBitfield;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_savedDataFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _savedDataFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
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
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              input.ReadMessageArray(tag, field_name, result.hirelings_, global::D3.Hireling.Info.DefaultInstance, extensionRegistry);
              break;
            }
            case 16: {
              result.hasActiveHireling = input.ReadUInt32(ref result.activeHireling_);
              break;
            }
            case 24: {
              result.hasAvailableHirelingsBitfield = input.ReadUInt32(ref result.availableHirelingsBitfield_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public pbc::IPopsicleList<global::D3.Hireling.Info> HirelingsList {
        get { return result.hirelings_; }
      }
      public int HirelingsCount {
        get { return result.HirelingsCount; }
      }
      public global::D3.Hireling.Info GetHirelings(int index) {
        return result.GetHirelings(index);
      }
      public Builder SetHirelings(int index, global::D3.Hireling.Info value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hirelings_[index] = value;
        return this;
      }
      public Builder SetHirelings(int index, global::D3.Hireling.Info.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hirelings_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddHirelings(global::D3.Hireling.Info value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hirelings_.Add(value);
        return this;
      }
      public Builder AddHirelings(global::D3.Hireling.Info.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hirelings_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeHirelings(scg::IEnumerable<global::D3.Hireling.Info> values) {
        result.hirelings_.Add(values);
        return this;
      }
      public Builder ClearHirelings() {
        result.hirelings_.Clear();
        return this;
      }
      
      public bool HasActiveHireling {
        get { return result.hasActiveHireling; }
      }
      public uint ActiveHireling {
        get { return result.ActiveHireling; }
        set { SetActiveHireling(value); }
      }
      public Builder SetActiveHireling(uint value) {
        result.hasActiveHireling = true;
        result.activeHireling_ = value;
        return this;
      }
      public Builder ClearActiveHireling() {
        result.hasActiveHireling = false;
        result.activeHireling_ = 0;
        return this;
      }
      
      public bool HasAvailableHirelingsBitfield {
        get { return result.hasAvailableHirelingsBitfield; }
      }
      public uint AvailableHirelingsBitfield {
        get { return result.AvailableHirelingsBitfield; }
        set { SetAvailableHirelingsBitfield(value); }
      }
      public Builder SetAvailableHirelingsBitfield(uint value) {
        result.hasAvailableHirelingsBitfield = true;
        result.availableHirelingsBitfield_ = value;
        return this;
      }
      public Builder ClearAvailableHirelingsBitfield() {
        result.hasAvailableHirelingsBitfield = false;
        result.availableHirelingsBitfield_ = 0;
        return this;
      }
    }
    static SavedData() {
      object.ReferenceEquals(global::D3.Hireling.Hireling.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
