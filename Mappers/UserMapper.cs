using KiuChessClub.DAOs.Users;
using KiuChessClub.DTOs.Users;

namespace KiuChessClub.Mappers;

public class UserMapper
{
    public static User FromRegistrationDto(RegisterUserRequest dto, byte[] hash, byte[] salt)
    {
        return new User
        {
            Username = dto.Username,
            Email = dto.Email,
            Gender = dto.Gender,
            PasswordHash = hash,
            PasswordSalt = salt,
            CreatedAt = DateTime.UtcNow
        };
    } 
}