﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteAspNet.ProductService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Categoria", Namespace="http://schemas.datacontract.org/2004/07/ProductosService.Models")]
    [System.SerializableAttribute()]
    public partial class Categoria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoriaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoriaId {
            get {
                return this.CategoriaIdField;
            }
            set {
                if ((this.CategoriaIdField.Equals(value) != true)) {
                    this.CategoriaIdField = value;
                    this.RaisePropertyChanged("CategoriaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://schemas.datacontract.org/2004/07/ProductosService.Models")]
    [System.SerializableAttribute()]
    public partial class Producto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductoId {
            get {
                return this.ProductoIdField;
            }
            set {
                if ((this.ProductoIdField.Equals(value) != true)) {
                    this.ProductoIdField = value;
                    this.RaisePropertyChanged("ProductoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductService.IServiceProduct")]
    public interface IServiceProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/CrearCategoria", ReplyAction="http://tempuri.org/IServiceProduct/CrearCategoriaResponse")]
        bool CrearCategoria(ClienteAspNet.ProductService.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/CrearCategoria", ReplyAction="http://tempuri.org/IServiceProduct/CrearCategoriaResponse")]
        System.Threading.Tasks.Task<bool> CrearCategoriaAsync(ClienteAspNet.ProductService.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/ActualizarCategoria", ReplyAction="http://tempuri.org/IServiceProduct/ActualizarCategoriaResponse")]
        bool ActualizarCategoria(ClienteAspNet.ProductService.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/ActualizarCategoria", ReplyAction="http://tempuri.org/IServiceProduct/ActualizarCategoriaResponse")]
        System.Threading.Tasks.Task<bool> ActualizarCategoriaAsync(ClienteAspNet.ProductService.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/EliminarCategoria", ReplyAction="http://tempuri.org/IServiceProduct/EliminarCategoriaResponse")]
        bool EliminarCategoria(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/EliminarCategoria", ReplyAction="http://tempuri.org/IServiceProduct/EliminarCategoriaResponse")]
        System.Threading.Tasks.Task<bool> EliminarCategoriaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/ListarCategorias", ReplyAction="http://tempuri.org/IServiceProduct/ListarCategoriasResponse")]
        ClienteAspNet.ProductService.Categoria[] ListarCategorias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/ListarCategorias", ReplyAction="http://tempuri.org/IServiceProduct/ListarCategoriasResponse")]
        System.Threading.Tasks.Task<ClienteAspNet.ProductService.Categoria[]> ListarCategoriasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/VerCategoria", ReplyAction="http://tempuri.org/IServiceProduct/VerCategoriaResponse")]
        ClienteAspNet.ProductService.Categoria VerCategoria(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/VerCategoria", ReplyAction="http://tempuri.org/IServiceProduct/VerCategoriaResponse")]
        System.Threading.Tasks.Task<ClienteAspNet.ProductService.Categoria> VerCategoriaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/CrearProducto", ReplyAction="http://tempuri.org/IServiceProduct/CrearProductoResponse")]
        bool CrearProducto(ClienteAspNet.ProductService.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/CrearProducto", ReplyAction="http://tempuri.org/IServiceProduct/CrearProductoResponse")]
        System.Threading.Tasks.Task<bool> CrearProductoAsync(ClienteAspNet.ProductService.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/ActualizarProducto", ReplyAction="http://tempuri.org/IServiceProduct/ActualizarProductoResponse")]
        bool ActualizarProducto(ClienteAspNet.ProductService.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/ActualizarProducto", ReplyAction="http://tempuri.org/IServiceProduct/ActualizarProductoResponse")]
        System.Threading.Tasks.Task<bool> ActualizarProductoAsync(ClienteAspNet.ProductService.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/EliminarProducto", ReplyAction="http://tempuri.org/IServiceProduct/EliminarProductoResponse")]
        bool EliminarProducto(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/EliminarProducto", ReplyAction="http://tempuri.org/IServiceProduct/EliminarProductoResponse")]
        System.Threading.Tasks.Task<bool> EliminarProductoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/ListarProductos", ReplyAction="http://tempuri.org/IServiceProduct/ListarProductosResponse")]
        ClienteAspNet.ProductService.Producto[] ListarProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/ListarProductos", ReplyAction="http://tempuri.org/IServiceProduct/ListarProductosResponse")]
        System.Threading.Tasks.Task<ClienteAspNet.ProductService.Producto[]> ListarProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/VerProducto", ReplyAction="http://tempuri.org/IServiceProduct/VerProductoResponse")]
        ClienteAspNet.ProductService.Producto VerProducto(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/VerProducto", ReplyAction="http://tempuri.org/IServiceProduct/VerProductoResponse")]
        System.Threading.Tasks.Task<ClienteAspNet.ProductService.Producto> VerProductoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/Filtrar", ReplyAction="http://tempuri.org/IServiceProduct/FiltrarResponse")]
        ClienteAspNet.ProductService.Producto[] Filtrar(string parametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/Filtrar", ReplyAction="http://tempuri.org/IServiceProduct/FiltrarResponse")]
        System.Threading.Tasks.Task<ClienteAspNet.ProductService.Producto[]> FiltrarAsync(string parametro);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceProductChannel : ClienteAspNet.ProductService.IServiceProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceProductClient : System.ServiceModel.ClientBase<ClienteAspNet.ProductService.IServiceProduct>, ClienteAspNet.ProductService.IServiceProduct {
        
        public ServiceProductClient() {
        }
        
        public ServiceProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CrearCategoria(ClienteAspNet.ProductService.Categoria categoria) {
            return base.Channel.CrearCategoria(categoria);
        }
        
        public System.Threading.Tasks.Task<bool> CrearCategoriaAsync(ClienteAspNet.ProductService.Categoria categoria) {
            return base.Channel.CrearCategoriaAsync(categoria);
        }
        
        public bool ActualizarCategoria(ClienteAspNet.ProductService.Categoria categoria) {
            return base.Channel.ActualizarCategoria(categoria);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarCategoriaAsync(ClienteAspNet.ProductService.Categoria categoria) {
            return base.Channel.ActualizarCategoriaAsync(categoria);
        }
        
        public bool EliminarCategoria(int id) {
            return base.Channel.EliminarCategoria(id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarCategoriaAsync(int id) {
            return base.Channel.EliminarCategoriaAsync(id);
        }
        
        public ClienteAspNet.ProductService.Categoria[] ListarCategorias() {
            return base.Channel.ListarCategorias();
        }
        
        public System.Threading.Tasks.Task<ClienteAspNet.ProductService.Categoria[]> ListarCategoriasAsync() {
            return base.Channel.ListarCategoriasAsync();
        }
        
        public ClienteAspNet.ProductService.Categoria VerCategoria(int id) {
            return base.Channel.VerCategoria(id);
        }
        
        public System.Threading.Tasks.Task<ClienteAspNet.ProductService.Categoria> VerCategoriaAsync(int id) {
            return base.Channel.VerCategoriaAsync(id);
        }
        
        public bool CrearProducto(ClienteAspNet.ProductService.Producto producto) {
            return base.Channel.CrearProducto(producto);
        }
        
        public System.Threading.Tasks.Task<bool> CrearProductoAsync(ClienteAspNet.ProductService.Producto producto) {
            return base.Channel.CrearProductoAsync(producto);
        }
        
        public bool ActualizarProducto(ClienteAspNet.ProductService.Producto producto) {
            return base.Channel.ActualizarProducto(producto);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarProductoAsync(ClienteAspNet.ProductService.Producto producto) {
            return base.Channel.ActualizarProductoAsync(producto);
        }
        
        public bool EliminarProducto(int id) {
            return base.Channel.EliminarProducto(id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarProductoAsync(int id) {
            return base.Channel.EliminarProductoAsync(id);
        }
        
        public ClienteAspNet.ProductService.Producto[] ListarProductos() {
            return base.Channel.ListarProductos();
        }
        
        public System.Threading.Tasks.Task<ClienteAspNet.ProductService.Producto[]> ListarProductosAsync() {
            return base.Channel.ListarProductosAsync();
        }
        
        public ClienteAspNet.ProductService.Producto VerProducto(int id) {
            return base.Channel.VerProducto(id);
        }
        
        public System.Threading.Tasks.Task<ClienteAspNet.ProductService.Producto> VerProductoAsync(int id) {
            return base.Channel.VerProductoAsync(id);
        }
        
        public ClienteAspNet.ProductService.Producto[] Filtrar(string parametro) {
            return base.Channel.Filtrar(parametro);
        }
        
        public System.Threading.Tasks.Task<ClienteAspNet.ProductService.Producto[]> FiltrarAsync(string parametro) {
            return base.Channel.FiltrarAsync(parametro);
        }
    }
}
