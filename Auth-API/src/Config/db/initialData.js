import bcrypt from "bcrypt";
import User from "../../Modules/user/Model/User.js";

export async function createInitialData() {
  try {
    await User.sync({ force: true });

    let password = await bcrypt.hash("123456", 10);

    await User.create({
      name: "User 1",
      email: "user1@gmail.com",
      password: password,
    });

    await User.create({
      name: "User 2",
      email: "user2@gmail.com",
      password: password,
    });
  } catch (err) {
    console.log(err);
  }
}