import React from 'react';
import { Route, RouteProps } from 'react-router-dom';
import { useAuthContext } from '../context/auth';
import { RoutePaths } from '../utils/enum';
const Redirect = require("react-router-dom");


const PrivateRoute = ({ component: Component, path }: RouteProps) => {
  const authContext = useAuthContext();
  console.log("test: ", authContext.user)
  if (!authContext.user.id) {
    return <Redirect to={RoutePaths.Login} />;
  }

  return <Route component={Component} path={path} />;
};

export default PrivateRoute;