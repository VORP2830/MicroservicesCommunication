import UserService from "../Service/UserService.js";

class UserController {
  async getAccessToken(req, res) {
    let user = await UserService.getAccessToken(req);
    return res.status(user.status).json(user);
   }

  async findByEmail(req, res) {
    let user = await UserService.findByEmail(req);
    return res.status(user.status).json(user);
  }
}

export default new UserController();