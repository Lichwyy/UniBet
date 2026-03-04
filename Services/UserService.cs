using UniBet.DTOs;
using UniBet.Entities;
using UniBet.Interfaces.IRepositories;
using UniBet.Interfaces.IServices;

namespace UniBet.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) { 
            _userRepository = userRepository;
        } 
        public void Deposit(DepositDTO depositDTO)
        {
            try
            {
                if (depositDTO == null)
                {
                    throw new Exception("Envie um objeto de depósito válido");
                }

                Deposit deposit = new Deposit();
                deposit.DepositType = depositDTO.DepositType;
                deposit.DepositAmount = depositDTO.DepositAmount;
                deposit.UserId = depositDTO.UserId;
                //_depositUser.save
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User GetUserData(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
