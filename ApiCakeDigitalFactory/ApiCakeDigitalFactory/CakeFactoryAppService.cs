using ApiCakeDigitalFactory.Models;
using HostManager.Backend.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HostManager.Backend
{
    
    public class CakeFactoryAppService
    {
        private readonly CakeDigitalFactoryDBContext _DataContext;
        public CakeFactoryAppService(CakeDigitalFactoryDBContext CakeFactoryContext
            )
        {
            _DataContext = CakeFactoryContext;
        }

        //#endregion Properties

        //#region Methods
        //private TimeSpan DatesDifference(DateTime dateFrom, DateTime dateTo)
        //{
        //    TimeSpan span = (dateTo - dateFrom);

        //    return span;
        //}
        //#endregion Methods

        //#region Clients
        //private Client MaterializeClient(ClientDTO request)
        //{
        //    Client newPreference = new Client
        //    {
        //        Name = request.Name,
        //        Email = request.Email,
        //        Phone = request.Phone,
        //        VisitsCount = request.VisitsCount
        //    };

        //    return newPreference;
        //}

        //public Response GetClients()
        //{
        //    IEnumerable<Client> modelList = _DataContext.Client;
        //    return new Response { Data = modelList };
        //}

        //public Response GetClientById(int clientId)
        //{
        //    Client modelList = _DataContext.Client.FirstOrDefault(x => x.ClientId == clientId);
        //    return new Response { Data = modelList };
        //}

        //public Response GetClientFiltered(string filter) 
        //{
        //    IEnumerable<Client> clients = _DataContext.Client;

        //    return new Response { Data = clients.Where(x => x.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase)) };
        //}

        //public Response CreateClient(ClientDTO request)
        //{
        //    string validation = _DomainService.ValidateNewClient(request);
        //    if (!string.IsNullOrWhiteSpace(validation))
        //    {
        //        return new Response { Message = validation };
        //    }

        //    if (string.IsNullOrWhiteSpace(request.Email))
        //    {
        //        request.Email = string.Empty;
        //    }

        //    if (string.IsNullOrWhiteSpace(request.Phone))
        //    {
        //        request.Phone = string.Empty;
        //    }

        //    Client entity = MaterializeClient(request);

        //    _DataContext.Add(entity);
        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Cliente {entity.Name} creado con exito " , Data= entity};
        //}

        //public Response UpdateClient(ClientDTO request)
        //{

        //    Client entity = _DataContext.Client.Find(request.ClientId);

        //    if (entity == null)
        //    {
        //        return new Response { Message = $" Cliente {request.Name} no se encuentra" };
        //    }

        //    if (string.IsNullOrWhiteSpace(request.Email))
        //    {
        //        request.Email = string.Empty;
        //    }

        //    if (string.IsNullOrWhiteSpace(request.Phone))
        //    {
        //        request.Phone = string.Empty;
        //    }

        //    entity.Name = request.Name;
        //    entity.Email = request.Email;
        //    entity.Phone = request.Phone;
        //    entity.VisitsCount = request.VisitsCount;

        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Cliente {request.Name} actualizado con exito" };

        //}

        //public Response DeleteClient(int clientId)
        //{
        //    Client entity = _DataContext.Client.Find(clientId);

        //    if (entity == null)
        //    {
        //        return new Response { Message = "No existe el cliente" };
        //    }

        //    _DataContext.Remove(entity);
        //    _DataContext.SaveChanges();
        //    return new Response { Message = $"Cliente eliminado con exito" };
        //}

        //#endregion Clients

        //#region ClientStatus
        //private OrderStatus MaterializeOrderStatus(OrderStausDTO request)
        //{
        //    OrderStatus newPreference = new OrderStatus
        //    {
        //        Name = request.Name,
        //        Minutes = request.Minutes,
        //        Status = request.Status
        //    };

        //    return newPreference;
        //}

        //public Response GetClientStatuses()
        //{
        //    IEnumerable<OrderStatus> modelList = _DataContext.ClientStatus;
        //    return new Response { Data = modelList };
        //}

        //public Response GetClientStatusById(int clientStatusId)
        //{
        //    OrderStatus modelList = _DataContext.ClientStatus.FirstOrDefault(x => x.OrderStatusId == clientStatusId);
        //    return new Response { Data = modelList };
        //}

        //public Response CreateClientStatus(OrderStausDTO request)
        //{
        //    string validation = _DomainService.ValidateNewClientStatus(request);
        //    if (!string.IsNullOrWhiteSpace(validation))
        //    {
        //        return new Response { Message = validation };
        //    }

        //    OrderStatus entity = MaterializeOrderStatus(request);

        //    _DataContext.Add(entity);
        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Restaurante {entity.Name} creado con exito " };
        //}

        //public Response UpdateClientStatus(OrderStausDTO request)
        //{

        //    OrderStatus entity = _DataContext.ClientStatus.Find(request.ClientStatusId);

        //    if (entity == null)
        //    {
        //        return new Response { Message = $" ClientStatus {request.Name} no se encuentra" };
        //    }

        //    entity.Name = request.Name;
        //    entity.Minutes = request.Minutes;
        //    entity.Status = request.Status;

        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"ClientStatus {request.Name} actualizado con exito" };

        //}

        //public Response DeleteClientStatus(int clientStatusId)
        //{
        //    OrderStatus entity = _DataContext.ClientStatus.Find(clientStatusId);

        //    if (entity == null)
        //    {
        //        return new Response { Message = "No existe el ClientStatus" };
        //    }

        //    _DataContext.Remove(entity);
        //    _DataContext.SaveChanges();
        //    return new Response { Message = $"ClientStatus eliminado con exito" };
        //}
        //#endregion ClientStatus

        //#region Panaderias
        //private Panaderia MaterializePanaderia(PanaderiaDTO request)
        //{
        //    Panaderia newPreference = new Panaderia
        //    {
        //        NombreTienda = request.NombreTienda,
        //        DireccionTienda = request.DireccionTienda,
        //        CorreoTienda = request.CorreoTienda,
        //        TelefonoTienda = request.TelefonoTienda,
        //        Img = request.Img
        //    };

        //    return newPreference;
        //}

        //public Response GetRestaurants()
        //{
        //    IEnumerable<Panaderia> modelList = _DataContext.Panaderias;
        //    return new Response { Data = modelList };
        //}


        //public Response GetRestaurantsName() 
        //{
        //    IEnumerable<Panaderia> restaurants = _DataContext.Panaderias;

        //    return new Response { Data = restaurants.Select(x => x.NombreTienda) };
        //}


        //public Response GetRestaurantsById(int restaurantId)
        //{
        //    Panaderia modelList = _DataContext.Panaderias.FirstOrDefault(x => x.Id == restaurantId);
        //    return new Response { Data = modelList };
        //}

        //public Response CreateRestaurant(PanaderiaDTO request)
        //{
        //    string validation = _DomainService.ValidateNewRestaurant(request);
        //    if (!string.IsNullOrWhiteSpace(validation))
        //    {
        //        return new Response { Message = validation };
        //    }

        //    Panaderia entity = MaterializePanaderia(request);

        //    _DataContext.Add(entity);
        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Panaderia {entity.NombreTienda} creado con exito " };
        //}

        //public Response UpdateRestaurant(PanaderiaDTO request)
        //{

        //    Panaderia entity = _DataContext.Panaderias.Find(request.Id);

        //    if (entity == null)
        //    {
        //        return new Response { Message = $" Restaurante {request.NombreTienda} no se encuentra" };
        //    }

        //    entity.NombreTienda = request.NombreTienda;
        //    entity.DireccionTienda = request.DireccionTienda;
        //    entity.CorreoTienda = request.CorreoTienda;

        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Restaurante {request.NombreTienda} actualizado con exito" };

        //}

        //public Response DeleteRestaurant(int restaurantId)
        //{
        //    Panaderia entity = _DataContext.Panaderias.Find(restaurantId);

        //    if (entity == null)
        //    {
        //        return new Response { Message = "No existe el Restaurante" };
        //    }

        //    _DataContext.Remove(entity);
        //    _DataContext.SaveChanges();
        //    return new Response { Message = $"Restaurante eliminado con exito" };
        //}
        //#endregion Panaderias

        //#region Productos
        //private Productos MaterializeProductos(ProductosDTO request)
        //{
        //    Productos newPreference = new Productos
        //    {
        //        NombreProducto = request.NombreProducto,
        //        Precio = request.Precio,
        //        IdTienda = request.IdTienda,
        //        Existencia = request.Existencia
        //    };

        //    return newPreference;
        //}

        //public Response GetProducts()
        //{
        //    IEnumerable<Productos> modelList = _DataContext.Productos;
        //    return new Response { Data = modelList };
        //}

        //public Response GetSectionSelection()
        //{
        //    IEnumerable<Productos> sections = _DataContext.Productos;
        //    if (sections.Any())
        //    {
        //        var result = sections.Select(x => new ProductosDTO { NombreProducto = x.NombreProducto, Id = x.Id }).ToList();

        //        return new Response { Data = result };
        //    }

        //    return new Response { Message = "No hay preferencias que seleccionar" };
        //}

        //public Response GetSectionById(int sectionId)
        //{
        //    Productos modelList = _DataContext.Productos.FirstOrDefault(x => x.Id == sectionId);
        //    return new Response { Data = modelList };
        //}

        //public Response CreateSection(ProductosDTO request)
        //{
        //    string validation = _DomainService.ValidateNewSection(request);
        //    if (!string.IsNullOrWhiteSpace(validation))
        //    {
        //        return new Response { Message = validation };
        //    }

        //    Productos entity = MaterializeProductos(request);

        //    _DataContext.Add(entity);
        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Producto {entity.NombreProducto} creado con exito " };
        //}

        //public Response CreateSectionPOSGC(ProductosDTO request)
        //{
        //    string validation = _DomainService.ValidateNewSection(request);
        //    if (!string.IsNullOrWhiteSpace(validation))
        //    {
        //        return new Response { Message = validation };
        //    }

        //    Productos entity = MaterializeProductos(request);

        //    _DataContext.Add(entity);
        //    _DataContext.SaveChanges();

        //    return new Response { Message = string.Empty };
        //}

        //public Response UpdateSection(ProductosDTO request)
        //{

        //    Productos entity = _DataContext.Productos.Find(request.Id);

        //    if (entity == null)
        //    {
        //        return new Response { Message = $" Producto {request.NombreProducto} no se encuentra" };
        //    }

        //    entity.NombreProducto = request.NombreProducto;
        //    entity.Precio = request.Precio;
        //    entity.IdTienda = request.IdTienda;
        //    entity.Existencia = request.Existencia;

        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Producto {request.NombreProducto} actualizado con exito" };

        //}

        //public Response UpdateSectionPOSGC(ProductosDTO request)
        //{

        //    Productos entity = _DataContext.Productos.Find(request.Id);

        //    if (entity == null)
        //    {
        //        return new Response { Message = $" Producto {request.NombreProducto} no se encuentra" };
        //    }

        //    entity.NombreProducto = request.NombreProducto;
        //    entity.Precio = request.Precio;
        //    entity.IdTienda = request.IdTienda;
        //    entity.Existencia = request.Existencia;

        //    _DataContext.SaveChanges();

        //    return new Response { Message = string.Empty };

        //}

        //public Response DeleteSection(int sectionId)
        //{
        //    Productos entity = _DataContext.Productos.Find(sectionId);

        //    if (entity == null)
        //    {
        //        return new Response { Message = "No existe la sección" };
        //    }

        //    _DataContext.Remove(entity);
        //    _DataContext.SaveChanges();
        //    return new Response { Message = $"Seccion eliminada con exito" };
        //}
        //#endregion Productos

        //#region User
        ////private User MaterializeUser(UserDTO request)
        ////{
        ////    User newPreference = new User
        ////    {
        ////        UserName = request.UserName,
        ////        UserId = request.UserId,
        ////        IsAdmin = request.IsAdmin,
        ////        PassWord = request.PassWord
        ////    };

        ////    return newPreference;
        ////}

        //public Response GetUsers()
        //{
        //    IEnumerable<User> modelList = _DataContext.User;
        //    return new Response { Data = modelList };
        //}

        ////public Response GetUserById(int userId)
        ////{
        ////    User modelList = _DataContext.User.FirstOrDefault(x => x.UserId == userId);
        ////    return new Response { Data = modelList };
        ////}

        ////public Response GetUserByName(string name){

        ////    User modelList = _DataContext.User.FirstOrDefault(x => x.UserName==name);
        ////    return new Response { Data = modelList };
        ////}

        //public Response CreateUser(UserDTO request)
        //{
        //    string validation = _DomainService.ValidateUser(request);
        //    if (!string.IsNullOrWhiteSpace(validation))
        //    {
        //        return new Response { Message = validation };
        //    }

        //    User entity = MaterializeUser(request);

        //    _DataContext.Add(entity);
        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Usuario {entity.UserName} creado con exito " };
        //}

        //public Response UpdateUser(UserDTO request)
        //{

        //    User entity = _DataContext.User.Find(request.UserId);

        //    if (entity == null)
        //    {
        //        return new Response { Message = $"Usuario {request.UserName} no se encuentra" };
        //    }

        //    entity.UserName = request.UserName;
        //    entity.PassWord = request.PassWord;
        //    entity.IsAdmin = request.IsAdmin;

        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"Usuario {request.UserName} actualizado con exito" };

        //}

        //public Response DeleteUser(int userId)
        //{
        //    User entity = _DataContext.User.Find(userId);

        //    if (entity == null)
        //    {
        //        return new Response { Message = "No existe el usuario" };
        //    }

        //    _DataContext.Remove(entity);
        //    _DataContext.SaveChanges();
        //    return new Response { Message = $"Usuario eliminado con exito" };
        //}
        //#endregion User


        public Response ValidateLogin(string user, string password) 
        {
            Usuario activeUser = _DataContext.Usuarios.FirstOrDefault(x => x.Nombre == user && x.Contraseña == password);
            
            if (activeUser==null)
            {
                return new Response { Message = "Usuario Inexistente o Credenciales Invalidas" };
            }
                return new Response { Roll = activeUser.Roll, Message= $"Bienvenido {activeUser.Contraseña}" };

        }

        public Response CreateUser(Usuario request)
        {
            if (string.IsNullOrWhiteSpace(request.Nombre))
            {
                return new Response { Message = "Nombre no puede estar vacio" };
            }

            if (string.IsNullOrWhiteSpace(request.Contraseña))
            {
                return new Response { Message = "Contrasena no puede estar vacio" };
            }

            _DataContext.Add(request);
            _DataContext.SaveChanges();

            return new Response { Message = $"Usuario {request.Nombre} creado con exito " };
        }

        public Response CreateProduct(Producto request)
        {
            if (string.IsNullOrWhiteSpace(request.Nombre))
            {
                return new Response { Message = "Nombre no puede estar vacio" };
            }

            if (string.IsNullOrWhiteSpace(request.Img))
            {
                return new Response { Message = "Imagen no puede estar vacio" };
            }


            _DataContext.Add(request);
            _DataContext.SaveChanges();

            return new Response { Message = $"Producto {request.Nombre} creado con exito " };
        }

        public Response CreateDetail(Detalle request)
        {
            if (string.IsNullOrWhiteSpace(request.Nombre))
            {
                return new Response { Message = "Nombre no puede estar vacio" };
            }
            _DataContext.Add(request);
            _DataContext.SaveChanges();

            return new Response { Message = $"Detalle {request.Nombre} creado con exito " };
        }


        //public void AddingSessionManagement(string user) 
        //{

        //    SessionManagement sessionManagement = new SessionManagement
        //    {
        //        User = user,
        //        StartSession = DateTime.Now,
        //        IsLogout = false

        //    };

        //    _DataContext.Add(sessionManagement);
        //    _DataContext.SaveChanges();

        //}

        //public Response DeletingSessionWhenLogout(string user) 
        //{
        //    SessionManagement activeUser = _DataContext.sessionManagments.FirstOrDefault(x => x.User == user);

        //    if (activeUser == null) 
        //    {
        //        return new Response { Message = "La sesion se encontraba cerrada" };
        //    }

        //    _DataContext.Remove(activeUser);
        //    _DataContext.SaveChanges();

        //    return new Response { Data = activeUser };

        //}

        //public Response GetActualSession(string user) 
        //{
        //    User activeUser = _DataContext.User.FirstOrDefault(x => x.UserName == user);

        //    if (activeUser == null)
        //    {
        //        return new Response { Message = "no hay sesion activa para el usuario"};
        //    }

        //    return new Response { Data = activeUser };
        //}

        //#endregion

        //#region Encargos
        //public Response getEncargos()
        //{
        //    IEnumerable<Encargo> encargos = _DataContext.Encargos;

        //    return new Response { Data = encargos };
        //}

        //public Response CreateEncargo(EncargoDto request)
        //{
        //    Encargo encargo = MaterializeEncargo(request);

        //    _DataContext.Add(encargo);
        //    _DataContext.SaveChanges();

        //    return new Response { Message = $"El encargo con la fecha {request.FechaEncargo} fue creado exitosamente" };
        //}

        //public Response ActualizarEstatusDelEncargoEnviado(int encargoId)
        //{
        //    Encargo encargo = _DataContext.Encargos.FirstOrDefault(x => x.Id == encargoId);

        //    if (encargo == null)
        //    {
        //        return new Response { Message = "El encargo no existe" };
        //    }

        //    encargo.ActualizarEstadoAEnviado();

        //    _DataContext.SaveChanges();

        //    return new Response { Message = "El encargo fue actualizado con exito" };
        //}


        //public Encargo MaterializeEncargo(EncargoDto request)
        //{
        //    Encargo newEncargo = new Encargo
        //    {
        //        IdTienda = request.IdTienda,
        //        IdUsuario = request.IdUsuario,
        //        StatusOrden = request.StatusOrden,
        //        FechaEncargo = request.FechaEncargo,
        //        FechaEnvio = request.FechaEnvio,
        //        FechaRecibido = request.FechaRecibido
        //    };

        //    return newEncargo;
        //}

        //public Response EliminarUnEncargo(int encargoId)
        //{
        //    Encargo encargo = _DataContext.Encargos.FirstOrDefault(x => x.Id == encargoId);

        //    if (encargo == null)
        //    {
        //        return new Response { Message = "el encargo que trata de eliminar no existe" };
        //    }

        //    _DataContext.Remove(encargo);
        //    _DataContext.SaveChanges();
        //    return new Response { Message = "El encargo se elimino con exito" };
        //}

    }

}

