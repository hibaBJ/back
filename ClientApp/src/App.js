import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';

import { Counter } from './components/Counter';
import { FetchData } from './components/FetchData';
import { Home } from './components/Home';
import { Layout } from './components/Layout';


import './custom.css';

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Routes>
          {AppRoutes.map((route, index) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })}
           <Route exact path='/' component={Home}></Route>
           <Route path='/Counter' component={Counter}></Route>
           <Route path='/Fetch-Data' component={FetchData}></Route>
               
             
        </Routes>
      </Layout>
    );
  }
}
