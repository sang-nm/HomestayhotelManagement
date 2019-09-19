using HomeStayWCF.Module;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HomeStay" in code, svc and config file together.
public class HomeStay : IHomeStay
{
    private HomeStayDataContext dataContext = new HomeStayDataContext();

    #region Users
    public User getSingleUser(int userID)
    {
        return dataContext.Users.FirstOrDefault(x => x.UserID == userID);
    }
    public List<User> getAllUser()
    {
        return dataContext.Users.ToList();
    }
    public List<User> FindUsers(string NameKeyword)
    {
        return dataContext.Users.Where(x => x.UserName.Contains(NameKeyword) || x.FirstName.Contains(NameKeyword) || x.LastName.Contains(NameKeyword)).ToList();
    }
    public User checkLogin(string userName, string userPassword)
    {
        byte[] decrypted;
        User user = new User();
        user = dataContext.Users.FirstOrDefault(x => x.UserName.Equals(userName));
        if (user != null)
        {
            Cryptography cryptography = new Cryptography(user.UserName);
            decrypted = cryptography.decrypt(user.UserPassword.ToArray());
            if (userPassword.Equals(Encoding.UTF8.GetString(decrypted)))
                return user;
        }
        return null;
    }
    public bool InsertUser(User insertedUser, int RoleID)
    {
        try
        {
            User user = new User()
            {
                UserName = insertedUser.UserName,
                UserPassword = insertedUser.UserPassword,
                Address = insertedUser.Address,
                Birthday = insertedUser.Birthday,
                ContainerName = insertedUser.ContainerName,
                Email = insertedUser.Email,
                FirstName = insertedUser.FirstName,
                Gender = insertedUser.Gender,
                Image = insertedUser.Image,
                LastName = insertedUser.LastName,
                PhoneNumber = insertedUser.PhoneNumber,
                RoleID = RoleID,
            };
            Cryptography cryptography = new Cryptography(user.UserName);

            byte[] encrypted = cryptography.encrypt(Encoding.UTF8.GetString(user.UserPassword.ToArray()));

            user.UserPassword = new System.Data.Linq.Binary(encrypted);

            dataContext.Users.InsertOnSubmit(user);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public bool UpdateUser(User updatedUser)
    {
        User user = dataContext.Users.FirstOrDefault(x => x.UserID == updatedUser.UserID);
        user.UserName = updatedUser.UserName;
        user.FirstName = updatedUser.FirstName;
        user.LastName = updatedUser.LastName;
        user.Gender = updatedUser.Gender;
        user.Address = updatedUser.Address;
        user.Birthday = updatedUser.Birthday;
        user.ContainerName = updatedUser.ContainerName;
        user.Image = updatedUser.Image;
        user.PhoneNumber = updatedUser.PhoneNumber;
        user.RoleID = updatedUser.RoleID;
        user.Email = updatedUser.Email;
        try
        {
            Cryptography cryptography = new Cryptography(updatedUser.UserName);

            byte[] encrypted = cryptography.encrypt(Encoding.UTF8.GetString(updatedUser.UserPassword.ToArray()));

            user.UserPassword = new System.Data.Linq.Binary(encrypted);

            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public bool DeleteUser(User deletedUser)
    {
        try
        {
            User user = dataContext.Users.FirstOrDefault(x => x.UserID == deletedUser.UserID);
            dataContext.Users.DeleteOnSubmit(user);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }
    }

    //public string SaveImage(byte[] image, string linkToImageName)
    //{
    //    string ImageName = Path.GetFileName(linkToImageName);
    //    string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"Images\User");
    //    if (!Directory.Exists(FolderPath))
    //    {
    //        Directory.CreateDirectory(FolderPath);
    //    }
    //    string linkToSaveImage = Path.Combine(FolderPath, ImageName);
    //    bitmap.Save(linkToSaveImage);
    //    bitmap.Dispose();
    //    return linkToSaveImage;
    //}
    #endregion

    #region Role
    public Role getSingleRole(int roleID)
    {
        return dataContext.Roles.Single(x => x.RoleID == roleID);
    }
    public List<Role> getAllRole()
    {
        return dataContext.Roles.ToList();
    }
    public List<Role> FindRoles(string NameKeyword)
    {
        return dataContext.Roles.Where(x => x.Name.Contains(NameKeyword) || x.Description.Contains(NameKeyword)).ToList();
    }
    public bool InsertRole(Role insertedRole)
    {
        try
        {
            dataContext.Roles.InsertOnSubmit(insertedRole);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }
    public bool UpdateRole(Role updatedRole)
    {
        Role role = dataContext.Roles.FirstOrDefault(x => x.RoleID == updatedRole.RoleID);
        role.Name = updatedRole.Name;
        role.Description = updatedRole.Description;

        try
        {
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public bool DeleteRole(Role deletedRole)
    {
        try
        {
            Role role = dataContext.Roles.FirstOrDefault(x => x.RoleID == deletedRole.RoleID);
            dataContext.Roles.DeleteOnSubmit(role);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }
    }


    #endregion

    #region Service
    public Service getSingleService(int serviceID)
    {
        return dataContext.Services.FirstOrDefault(x => x.ServiceID == serviceID);
    }
    public List<Service> getAllService()
    {
        return dataContext.Services.ToList();
    }
    public List<Service> FindService(string NameKeyword)
    {
        return dataContext.Services.Where(x => x.Name.Contains(NameKeyword) || x.Description.Contains(NameKeyword)).ToList();
    }
    public bool InsertService(Service insertedService)
    {
        try
        {
            dataContext.Services.InsertOnSubmit(insertedService);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }
    public bool UpdateService(Service updatedService)
    {
        Service service = dataContext.Services.FirstOrDefault(x => x.ServiceID == updatedService.ServiceID);
        service.Name = updatedService.Name;
        service.Description = updatedService.Description;
        service.Price = updatedService.Price;

        try
        {
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public bool DeleteService(Service deletedService)
    {
        try
        {
            Service service = dataContext.Services.FirstOrDefault(x => x.ServiceID == deletedService.ServiceID);
            dataContext.Services.DeleteOnSubmit(service);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }
    }
    #endregion

    #region Room
    public Room getSingleRoom(int roomID)
    {
        return dataContext.Rooms.FirstOrDefault(x => x.RoomID == roomID);
    }
    public List<Room> getAllRoom()
    {
        return dataContext.Rooms.ToList();
    }
    public List<Room> FindRoom(string NameKeyword)
    {
        return dataContext.Rooms.Where(x => x.RoomNumber.ToString().Contains(NameKeyword) || x.Description.Contains(NameKeyword)).ToList();
    }
    public int InsertRoom(Room insertedRoom, List<Service> services)
    {
        try
        {
            dataContext.Rooms.InsertOnSubmit(insertedRoom);
            dataContext.SubmitChanges();
            InsertRoom_Service(insertedRoom.RoomID, services);
            return insertedRoom.RoomID;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }

    }
    public int UpdateRoom(Room updatedRoom, List<Service> services)
    {
        Room room = dataContext.Rooms.FirstOrDefault(x => x.RoomID == updatedRoom.RoomID);
        room.RoomNumber = updatedRoom.RoomNumber;
        room.Description = updatedRoom.Description;

        DeleteAllRoom_ServicebyRoomID(updatedRoom.RoomID);
        InsertRoom_Service(updatedRoom.RoomID, services);
        try
        {
            dataContext.SubmitChanges();
            return updatedRoom.RoomID;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }
    }
    public bool DeleteRoom(Room deleteRoom)
    {
        try
        {
            Room room = dataContext.Rooms.FirstOrDefault(x => x.RoomID == deleteRoom.RoomID);
            dataContext.Rooms.DeleteOnSubmit(room);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }
    }

    private void InsertRoom_Service(int RoomID, List<Service> services)
    {
        List<Room_Service> lstRS = new List<Room_Service>();
        foreach (Service sv in services)
        {
            Room_Service rs = new Room_Service()
            {
                RoomID = RoomID,
                ServiceID = sv.ServiceID,
            };
            lstRS.Add(rs);
        }
        try
        {
            dataContext.Room_Services.InsertAllOnSubmit(lstRS);
            dataContext.SubmitChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public bool DeleteAllRoom_ServicebyRoomID(int RoomID)
    {
        List<Room_Service> lstRS = dataContext.Room_Services.Where(x => x.RoomID == RoomID).ToList();

        try
        {
            dataContext.Room_Services.DeleteAllOnSubmit(lstRS);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    #endregion


    #region Room_Service
    public List<Service> GetAllServiceByRoomID(int RoomID)
    {
        List<Room_Service> lstRS = dataContext.Room_Services.Where(x => x.RoomID == RoomID).ToList();
        List<Service> lstServices = new List<Service>();
        foreach (Room_Service rs in lstRS)
        {
            lstServices.Add(dataContext.Services.FirstOrDefault(x => x.ServiceID == rs.ServiceID));
        }
        return lstServices;
    }
    #endregion

    #region Image
    public List<Image> GetAllImagebyRoomID(int RoomID)
    {
        return dataContext.Images.Where(x => x.RoomID == RoomID).ToList();
    }

    public Image GetFirstImagebyRoomID(int RoomID)
    {
        return dataContext.Images.FirstOrDefault(x => x.RoomID == RoomID);
    }

    public bool InsertImage(Image InsertedImage)
    {
        try
        {
            dataContext.Images.InsertOnSubmit(InsertedImage);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
    public bool InsertListImage(List<Image> lstImage)
    {
        try
        {
            dataContext.Images.InsertAllOnSubmit(lstImage);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool DeleteAllImagebyRoomID(int RoomID)
    {
        List<Image> lstImage = dataContext.Images.Where(x => x.RoomID == RoomID).ToList();
        try
        {
            dataContext.Images.DeleteAllOnSubmit(lstImage);
            dataContext.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    #endregion
}
