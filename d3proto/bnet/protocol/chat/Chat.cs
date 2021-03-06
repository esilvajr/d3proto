// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol.chat {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public static partial class Chat {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Chat() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "CiJzZXJ2aWNlL2NoYXQvZGVmaW5pdGlvbi9jaGF0LnByb3RvEhJibmV0LnBy" + 
          "b3RvY29sLmNoYXQaHGxpYi9wcm90b2NvbC9hdHRyaWJ1dGUucHJvdG8aGWxp" + 
          "Yi9wcm90b2NvbC9lbnRpdHkucHJvdG8aHWxpYi9wcm90b2NvbC9pbnZpdGF0" + 
          "aW9uLnByb3RvGhFsaWIvcnBjL3JwYy5wcm90bxojc2VydmljZS9jaGFubmVs" + 
          "L2NoYW5uZWxfdHlwZXMucHJvdG8aKHNlcnZpY2UvY2hhdC9kZWZpbml0aW9u" + 
          "L2NoYXRfdHlwZXMucHJvdG8y1wIKC0NoYXRTZXJ2aWNlEmoKC0ZpbmRDaGFu" + 
          "bmVsEikuYm5ldC5wcm90b2NvbC5jaGFubmVsLkZpbmRDaGFubmVsUmVxdWVz" + 
          "dBoqLmJuZXQucHJvdG9jb2wuY2hhbm5lbC5GaW5kQ2hhbm5lbFJlc3BvbnNl" + 
          "IgSAtRgBEnAKDUNyZWF0ZUNoYW5uZWwSKy5ibmV0LnByb3RvY29sLmNoYW5u" + 
          "ZWwuQ3JlYXRlQ2hhbm5lbFJlcXVlc3QaLC5ibmV0LnByb3RvY29sLmNoYW5u" + 
          "ZWwuQ3JlYXRlQ2hhbm5lbFJlc3BvbnNlIgSAtRgCEmoKC0pvaW5DaGFubmVs" + 
          "EikuYm5ldC5wcm90b2NvbC5jaGFubmVsLkpvaW5DaGFubmVsUmVxdWVzdBoq" + 
          "LmJuZXQucHJvdG9jb2wuY2hhbm5lbC5Kb2luQ2hhbm5lbFJlc3BvbnNlIgSA" + 
          "tRgDQgOAAQA=");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::bnet.protocol.attribute.Proto.Attribute.RegisterAllExtensions(registry);
        global::bnet.protocol.Entity.RegisterAllExtensions(registry);
        global::bnet.protocol.invitation.Proto.Invitation.RegisterAllExtensions(registry);
        global::bnet.protocol.Rpc.RegisterAllExtensions(registry);
        global::bnet.protocol.channel.ChannelTypes.RegisterAllExtensions(registry);
        global::bnet.protocol.chat.ChatTypes.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::bnet.protocol.attribute.Proto.Attribute.Descriptor, 
          global::bnet.protocol.Entity.Descriptor, 
          global::bnet.protocol.invitation.Proto.Invitation.Descriptor, 
          global::bnet.protocol.Rpc.Descriptor, 
          global::bnet.protocol.channel.ChannelTypes.Descriptor, 
          global::bnet.protocol.chat.ChatTypes.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Services
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public abstract class ChatService : pb::IService {
    public abstract void FindChannel(
        pb::IRpcController controller,
        global::bnet.protocol.channel.FindChannelRequest request,
        global::System.Action<global::bnet.protocol.channel.FindChannelResponse> done);
    public abstract void CreateChannel(
        pb::IRpcController controller,
        global::bnet.protocol.channel.CreateChannelRequest request,
        global::System.Action<global::bnet.protocol.channel.CreateChannelResponse> done);
    public abstract void JoinChannel(
        pb::IRpcController controller,
        global::bnet.protocol.channel.JoinChannelRequest request,
        global::System.Action<global::bnet.protocol.channel.JoinChannelResponse> done);
    
    public static pbd::ServiceDescriptor Descriptor {
      get { return Chat.Descriptor.Services[0]; }
    }
    public pbd::ServiceDescriptor DescriptorForType {
      get { return Descriptor; }
    }
    
    public void CallMethod(
        pbd::MethodDescriptor method,
        pb::IRpcController controller,
        pb::IMessage request,
        global::System.Action<pb::IMessage> done) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.CallMethod() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          this.FindChannel(controller, (global::bnet.protocol.channel.FindChannelRequest) request,
              pb::RpcUtil.SpecializeCallback<global::bnet.protocol.channel.FindChannelResponse>(
              done));
          return;
        case 1:
          this.CreateChannel(controller, (global::bnet.protocol.channel.CreateChannelRequest) request,
              pb::RpcUtil.SpecializeCallback<global::bnet.protocol.channel.CreateChannelResponse>(
              done));
          return;
        case 2:
          this.JoinChannel(controller, (global::bnet.protocol.channel.JoinChannelRequest) request,
              pb::RpcUtil.SpecializeCallback<global::bnet.protocol.channel.JoinChannelResponse>(
              done));
          return;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public pb::IMessage GetRequestPrototype(pbd::MethodDescriptor method) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.GetRequestPrototype() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          return global::bnet.protocol.channel.FindChannelRequest.DefaultInstance;
        case 1:
          return global::bnet.protocol.channel.CreateChannelRequest.DefaultInstance;
        case 2:
          return global::bnet.protocol.channel.JoinChannelRequest.DefaultInstance;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public pb::IMessage GetResponsePrototype(pbd::MethodDescriptor method) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.GetResponsePrototype() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          return global::bnet.protocol.channel.FindChannelResponse.DefaultInstance;
        case 1:
          return global::bnet.protocol.channel.CreateChannelResponse.DefaultInstance;
        case 2:
          return global::bnet.protocol.channel.JoinChannelResponse.DefaultInstance;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public static Stub CreateStub(pb::IRpcChannel channel) {
      return new Stub(channel);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public class Stub : global::bnet.protocol.chat.ChatService {
      internal Stub(pb::IRpcChannel channel) {
        this.channel = channel;
      }
      
      private readonly pb::IRpcChannel channel;
      
      public pb::IRpcChannel Channel {
        get { return channel; }
      }
      
      public override void FindChannel(
          pb::IRpcController controller,
          global::bnet.protocol.channel.FindChannelRequest request,
          global::System.Action<global::bnet.protocol.channel.FindChannelResponse> done) {
        channel.CallMethod(Descriptor.Methods[0],
            controller, request, global::bnet.protocol.channel.FindChannelResponse.DefaultInstance,
            pb::RpcUtil.GeneralizeCallback<global::bnet.protocol.channel.FindChannelResponse, global::bnet.protocol.channel.FindChannelResponse.Builder>(done, global::bnet.protocol.channel.FindChannelResponse.DefaultInstance));
      }
      
      public override void CreateChannel(
          pb::IRpcController controller,
          global::bnet.protocol.channel.CreateChannelRequest request,
          global::System.Action<global::bnet.protocol.channel.CreateChannelResponse> done) {
        channel.CallMethod(Descriptor.Methods[1],
            controller, request, global::bnet.protocol.channel.CreateChannelResponse.DefaultInstance,
            pb::RpcUtil.GeneralizeCallback<global::bnet.protocol.channel.CreateChannelResponse, global::bnet.protocol.channel.CreateChannelResponse.Builder>(done, global::bnet.protocol.channel.CreateChannelResponse.DefaultInstance));
      }
      
      public override void JoinChannel(
          pb::IRpcController controller,
          global::bnet.protocol.channel.JoinChannelRequest request,
          global::System.Action<global::bnet.protocol.channel.JoinChannelResponse> done) {
        channel.CallMethod(Descriptor.Methods[2],
            controller, request, global::bnet.protocol.channel.JoinChannelResponse.DefaultInstance,
            pb::RpcUtil.GeneralizeCallback<global::bnet.protocol.channel.JoinChannelResponse, global::bnet.protocol.channel.JoinChannelResponse.Builder>(done, global::bnet.protocol.channel.JoinChannelResponse.DefaultInstance));
      }
    }
  }
  #endregion
  
}

#endregion Designer generated code
