using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHomeStay" in both code and config file together.
[ServiceContract]
public interface IHomeStay
{
    #region USER
    [OperationContract]
    User getSingleUser(int userID);
    [OperationContract]
    List<User> getAllUser();
    [OperationContract]
    List<User> FindUsers(string NameKeyword);
    [OperationContract]
    User checkLogin(string UserName, string Password);
    [OperationContract]
    bool InsertUser(User insertedUser, int RoleID);
    [OperationContract]
    bool UpdateUser(User updatedUser);
    [OperationContract]
    bool DeleteUser(User deletedUser);
    //[OperationContract]
    //string SaveImage(Bitmap bitmap, string linkToImageName);
    #endregion

    #region ROLE
    [OperationContract]
    Role getSingleRole(int RoleID);
    [OperationContract]
    List<Role> getAllRole();
    [OperationContract]
    List<Role> FindRoles(string NameKeyword);
    [OperationContract]
    bool InsertRole(Role insertedRole);
    [OperationContract]
    bool UpdateRole(Role updatedUser);
    [OperationContract]
    bool DeleteRole(Role deletedRole);
    #endregion

    #region SERVICE
    [OperationContract]
    Service getSingleService(int ServiceID);
    [OperationContract]
    List<Service> getAllService();
    [OperationContract]
    List<Service> FindService(string NameKeyword);
    [OperationContract]
    bool InsertService(Service insertedService);
    [OperationContract]
    bool UpdateService(Service updatedService);
    [OperationContract]
    bool DeleteService(Service deletedService);
    #endregion

    #region ROOM    
    [OperationContract]
    Room getSingleRoom(int roomID);
    [OperationContract]
    List<Room> getAllRoom();
    [OperationContract]
    List<Room> FindRoom(string NameKeyword);
    [OperationContract]
    int InsertRoom(Room insertedRoom, List<Service> services);
    [OperationContract]
    int UpdateRoom(Room updatedRoom, List<Service> services);
    [OperationContract]
    bool DeleteRoom(Room deletedRoom);
    [OperationContract]
    bool DeleteAllRoom_ServicebyRoomID(int RoomID);
    #endregion

    #region Room_Service
    [OperationContract]
    List<Service> GetAllServiceByRoomID(int RoomID);
    #endregion

    #region Image
    [OperationContract]
    List<Image> GetAllImagebyRoomID(int RoomID);
    [OperationContract]
    Image GetFirstImagebyRoomID(int RoomID);
    [OperationContract]
    bool InsertImage(Image InsertedImage);
    [OperationContract]
    bool InsertListImage(List<Image> lstImages);
    [OperationContract]
    bool DeleteAllImagebyRoomID(int RoomID);
    #endregion
}
